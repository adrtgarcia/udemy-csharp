Console.WriteLine("Stack Undo");

EditorTexto editor = new();

Console.WriteLine("\ndigitando...\n");
editor.DigitarChar('s');
editor.DigitarChar('t');
editor.DigitarChar('a');
editor.DigitarChar('c');
editor.DigitarChar('c');

Console.WriteLine("\nchamando undo...\n");
editor.Undo();

Console.WriteLine("\ndigitando...\n");
editor.DigitarChar('k');

public class EditorTexto
{
    private Stack<char> undoStack = new();
    private string texto = "";
    public void DigitarChar(char c)
    {
        texto += c;
        undoStack.Push(c);
        Console.WriteLine($"texto: {texto}");
    }
    public void Undo()
    {
        if (undoStack.Count > 0)
        {
            char ultimoChar = undoStack.Pop();
            texto = texto.Substring(0, texto.Length - 1);
            Console.WriteLine($"texto: {texto}");
        }
    }
}
