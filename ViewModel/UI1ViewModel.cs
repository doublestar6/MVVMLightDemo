using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MVVMLightDemo.Message;
using MVVMLightDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLightDemo.ViewModel
{
    public class UI1ViewModel : ViewModelBase
    {

        StudentModel smode = new StudentModel();
        public UI1ViewModel()
        {
            smode.id = "s111";
            smode.name = "sname";

        }
        
        public string Name
        {
            get
            {
                return smode.name;
            }
            set
            {
                smode.name = value;
                RaisePropertyChanged(() => Name);
            }
        } 
        public string TextLog
        {
            get { return smode.id; }
            set { smode.id = value; RaisePropertyChanged(() => TextLog); }
        }

        private RelayCommand btnCommand;
        public RelayCommand BtnCommand
        {
            get
            {
                if (btnCommand == null)
                    btnCommand = new RelayCommand(() => ExcuteBtnCommand());
                return btnCommand;

            }
            set { btnCommand = value; }
        }

        private void ExcuteBtnCommand()
        {
            Messenger.Default.Send<UIContext1>(new UIContext1("我是UI1！\n"));//向Log发送消息 （追加文本）
        }
    }
}
