namespace CSharpMethods.Metodos
{
    public class ManipulacaoDatas
    {
        public static DateTime SubtraiDias(DateTime data, int dias)
        {
            var result = data.AddDays(-dias);
            return result;
        }

        public static DateTime AcrescentaDias(DateTime data, int dias)
        {
            var result = data.AddDays(dias);
            return result;
        }

        public static DateTime SubtraiMeses(DateTime data, int meses)
        {
            var result = data.AddMonths(-meses);
            return result;
        }

        public static DateTime AcrescentaMeses(DateTime data, int meses)
        {
            var result = data.AddMonths(meses);
            return result;
        }

        public static DateTime SubtraiAnos(DateTime data, int anos)
        {
            var result = data.AddYears(-anos);
            return result;
        }

        public static DateTime AcrescentaAnos(DateTime data, int anos)
        {
            var result = data.AddYears(anos);
            return result;
        }
    }
}
