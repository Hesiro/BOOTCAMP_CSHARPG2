using HtmlAgilityPack;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://www.sbs.gob.pe/app/pp/sistip_portal/paginas/publicacion/tipocambiopromedio.aspx";

        using HttpClient client = new HttpClient();

        var response = await client.GetStringAsync(url);

        if (response != null)
        {
            var html = new HtmlDocument();
            html.LoadHtml(response);

            var table = html.DocumentNode.SelectSingleNode("//table[@id='ctl00_cphContent_rgTipoCambio_ctl00']");
            //Console.WriteLine(table.InnerText);

            var row = table.SelectSingleNode("//*[@id='ctl00_cphContent_rgTipoCambio_ctl00__0']");
            Console.WriteLine(row.InnerText);

            var nombreMoneda = row.SelectSingleNode(".//td[@class='APLI_fila3']");
            var montoMoneda = row.SelectNodes(".//td[@class='APLI_fila2']");

            var moneda = nombreMoneda.InnerText.Trim();
            var compra = montoMoneda[0].InnerText.Trim();
            var venta = montoMoneda[1].InnerText.Trim();

            Console.WriteLine(moneda);
            Console.WriteLine(compra);
            Console.WriteLine(venta);
        }
    }
}

