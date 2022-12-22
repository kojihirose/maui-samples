namespace MauiFile;

public partial class ReadFilePage : ContentPage
{
	public ReadFilePage()
	{
		InitializeComponent();
        this.Loaded += (_, _) =>
        {
            // �������ɃT���v���̏�������
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/sample.txt";
            if ( System.IO.File.Exists(path) == false )
            {
                string text = $"Sample Data at {DateTime.Now}";
                System.IO.File.WriteAllText(path, text);
            }
        };
	}

    /// <summary>
    /// System.IO.File �œǂݍ���
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FileReadClicked(object sender, EventArgs e)
	{
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/sample.txt";
        string text = System.IO.File.ReadAllText(path);
        message.Text = text;
    }

    /// <summary>
    /// StreamReader �œǂݍ���
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void StreamReadClicked(object sender, EventArgs e)
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/sample.txt";
        using var sr = new System.IO.StreamReader(path);
        string text = sr.ReadToEnd();
        message.Text = text;
    }

    /// <summary>
    /// Raw�t�H���_�[��ǂݍ���
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void RawReadClicked(object sender, EventArgs e)
    {
        using var st = await FileSystem.OpenAppPackageFileAsync("AboutAssets.txt");
        using var sr = new System.IO.StreamReader(st);
        string text = sr.ReadToEnd();
        message.Text = text;
    }
}