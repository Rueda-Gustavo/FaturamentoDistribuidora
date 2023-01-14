using System.Globalization;

class Program
{
    static void Main()
    {
        decimal faturamentoSP = 67836.43M ,faturamentoRJ = 36678.66M , faturamentoMG = 29229.88M,
        faturamentoES = 27165.48M, faturamentoOutros = 19849.53M;

        decimal total = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

        decimal mediaSP = faturamentoSP / total * 100;
        decimal mediaRJ = faturamentoRJ / total * 100;
        decimal mediaMG = faturamentoMG / total * 100;
        decimal mediaES = faturamentoES / total * 100;
        decimal mediaOutros = faturamentoOutros / total * 100;
        Console.WriteLine("SP: " + mediaSP.ToString("F3", CultureInfo.InvariantCulture) + "%");
        Console.WriteLine("RJ: " + mediaRJ.ToString("F3", CultureInfo.InvariantCulture) + "%");
        Console.WriteLine("MG: " + mediaMG.ToString("F3", CultureInfo.InvariantCulture) + "%");
        Console.WriteLine("ES: " + mediaES.ToString("F3", CultureInfo.InvariantCulture) + "%");
        Console.WriteLine("Outros: " + mediaOutros.ToString("F3", CultureInfo.InvariantCulture) + "%");

    }
}
