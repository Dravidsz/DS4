using Laboratorio8_9;

internal class Program
{
    private static void Main(string[] args)
    {
        Template temp1 = new Template();
        temp1.ponerVariable("var1", "Valor 1");
        temp1.ponerVariable("var2", "Valor 2");
        temp1.ponerVariable("var2", "Valor 2");
        temp1.verHtml("<br>Texto de prueba </br>");
    }
}