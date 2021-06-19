using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MVVMLightDemo.Message;
using MVVMLightDemo.Model;
using MVVMLightDemo.View;
using System;
using System.Windows.Controls;

namespace MVVMLightDemo.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 
        #region 成员
        TextBox TextBoxLog = new TextBox();
        public UserControl UserUI1 = new UI1View();
        public UserControl UserUI2 = new UI2View();
        #endregion
        public StudentModel student;
        #region 构造方法
        public MainViewModel()
        {
            ///Messenger：信使
            ///Recipient：收件人 
            Messenger.Default.Register<UIContext1>(this, msg =>  //注册Log消息 其内容是向日志文本追加文本
            {
                TextLog += msg.UIContext;
            });

            Messenger.Default.Register<UIContext2>(this, msg =>  //注册Log消息 其内容是向日志文本追加文本
            {
                TextLog = TextLog + msg.UIContext + msg.UIContext;
            });
        }
        #endregion

        #region 绑定属性
        //主页面的内容呈现器
        private UserControl _content;
        public UserControl Content
        {
            get { return _content; }
            set { _content = value;RaisePropertyChanged(() => Content);}
        }
        //文本日志
        private string textlog;
        public string TextLog
        {
            get { return textlog; }
            set { textlog = value; RaisePropertyChanged(() => TextLog); }
        }
        #endregion

        #region Button UI1命令
        private RelayCommand ui1Command;
        public RelayCommand UI1Command
        {
            get
            {
                if (ui1Command == null)
                    ui1Command = new RelayCommand(() => ExcuteUI1Command());
                return ui1Command;

            }
            set { ui1Command = value; }
        }

        private void ExcuteUI1Command()
        {
            Content = UserUI1;
        }
        #endregion

        #region Button UI2命令
        private RelayCommand ui2Command;
        public RelayCommand UI2Command
        {
            get
            {
                if (ui2Command == null)
                    ui2Command = new RelayCommand(() => ExcuteUI2Command());
                return ui2Command;

            }
            set { ui2Command = value; }
        }

        private void ExcuteUI2Command()
        {
            Content = UserUI2;
        }
        #endregion

        #region TextBox 
        private RelayCommand<TextBox> textBoxLoadedCommand;
        public RelayCommand<TextBox> TextBoxLoadedCommand
        {
            get
            {
                if (textBoxLoadedCommand == null)
                    textBoxLoadedCommand = new RelayCommand<TextBox>((p) => ExecuteTextBoxLoadedCommandCommand(p));
                return textBoxLoadedCommand;
            }
            set { textBoxLoadedCommand = value; }
        }

        private void ExecuteTextBoxLoadedCommandCommand(TextBox p)
        {
            TextBoxLog = (System.Windows.Controls.TextBox)p;//TextBox加载的时候把自身最为参数传递到ViewModel里来，有了这个参数就可以在ViewModel中使用该控件的属性方法以及事件
            TextBoxLog.IsReadOnly = true;//设为只读（使用控件的属性）
            TextBoxLog.TextChanged += TextBoxLog_TextChanged;//添加文本发生改变的事件（使用控件的事件）
        }

        private void TextBoxLog_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxLog.ScrollToEnd();//文本发生改变的时候让文本自动滚到底部（使用控件的方法）
        }
        #endregion
    }
}