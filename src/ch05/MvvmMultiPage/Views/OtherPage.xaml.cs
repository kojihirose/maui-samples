using MvvmMultiPage.ViewModels;

namespace MvvmMultiPage;

public partial class OtherPage : ContentPage
{
	public OtherPage()
	{
		InitializeComponent();
        this.Loaded += (s, e) =>
        {
            _vm = new OtherViewModel();
            _vm.Title = "�V�������";
            _vm.Author = "�Ėڟ���";
            _vm.Content = "�e���̖��S�C�����̎����瑹�΂��肵�Ă���B���w�Z�ɋ��鎞���w�Z�̓�K�����э~��Ĉ�T�ԂقǍ��𔲂�������������B�Ȃ�����Ȗ��ł������ƕ����l�����邩���m��ʁB�ʒi�[�����R�ł��Ȃ��B�V�z�̓�K�������o���Ă�����A�������̈�l����k�ɁA������В����Ă��A���������э~��鎖�͏o���܂��B�㒎��[���B�ƚ���������ł���B���g�ɕ��Ԃ����ċA���ė������A���₶���傫�Ȋ�����ē�K���炢�����э~��č��𔲂����z�����邩�Ɖ]��������A���̎��͔��������ɔ��Ō����܂��Ɠ������B";
            this.BindingContext = _vm;
        };
    }
    OtherViewModel _vm ;
}