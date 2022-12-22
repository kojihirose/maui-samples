using Microsoft.EntityFrameworkCore;

namespace MauiSQLite;

public partial class FisheriesListPage : ContentPage
{
	public FisheriesListPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
        // SQLite����ǂݍ���
        var context = new FisheriesDbContext();

		var q = from oroshi in context.T����
				join subject in context.T�i�� on oroshi.�i��Id equals subject.Id
				join market in context.T�s�� on oroshi.�s��Id equals market.Id
				join sale in context.T�̔����@ on oroshi.�̔����@Id equals sale.Id
				orderby oroshi.���t descending
				select new T����()
				{
					Id = oroshi.Id,
					�i��Id = oroshi.�i��Id,
					�̔����@Id = oroshi.�̔����@Id,
					�s��Id = oroshi.�s��Id,
					������ = oroshi.������,
					���t = oroshi.���t,
					�i�� = subject,
					�s�� = market,
					�̔����@ = sale,
				};
        var items = await q.Take(100).ToListAsync();
        coll.ItemsSource = items;

    }
}