using PratikAbstraction;

class Program
{
    static void Main(string[] args)
    {
        Employees graphicdesigner = new GraphicDesigner("Zeynep", "Kırıcı", "Graphic");
        Employees salesrepresentative = new SalesRepresentative("Burak", "Kırıcı", "Sales");
        Employees softwaredeveloper = new SoftwareDeveloper("Emre", "Can", "Devoloper");

        graphicdesigner.Task();
        salesrepresentative.Task();
        softwaredeveloper.Task();
    }
}