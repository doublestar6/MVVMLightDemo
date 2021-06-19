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
    public class UI2ViewModel : ViewModelBase
    {
        TeacherModel smode = new TeacherModel();
        public UI2ViewModel()
        {
            smode.id = "T111";
            smode.name = "Tname";

        }

        public string Name
        {
            get
            {
                return smode.id;
            }
            set
            {
                smode.id = value;
                RaisePropertyChanged(() => Name);
            }
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
            Messenger.Default.Send<UIContext2>(new UIContext2("我是UI2！\n"));//向Log发送消息 （追加文本）
        }
    }
}
