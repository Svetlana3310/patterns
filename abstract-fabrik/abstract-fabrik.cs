using System;

abstract class Button
{
    public abstract void Render();
}

abstract class TextBox
{
    public abstract void Display();
}

class WindowsButton : Button
{
    public override void Render()
    {
        Console.WriteLine("Render Windows Button");
    }
}

class WindowsTextBox : TextBox
{
    public override void Display()
    {
        Console.WriteLine("Display Windows TextBox");
    }
}

abstract class WindowsGUIFactory
{
    public abstract Button CreateButton();
    public abstract TextBox CreateTextBox();
}

class WindowsConcreteFactory : WindowsGUIFactory
{
    public override Button CreateButton()
    {
        return new WindowsButton();
    }

    public override TextBox CreateTextBox()
    {
        return new WindowsTextBox();
    }
}

class Application
{
    private WindowsGUIFactory _guiFactory;
    private Button _button;
    private TextBox _textBox;

    public Application(WindowsGUIFactory guiFactory)
    {
        _guiFactory = guiFactory;
        _button = _guiFactory.CreateButton();
        _textBox = _guiFactory.CreateTextBox();
    }

    public void Run()
    {
        _button.Render();
        _textBox.Display();
    }
}

class Program
{
    static void Main()
    {
        WindowsGUIFactory windowsFactory = new WindowsConcreteFactory();
        Application windowsApp = new Application(windowsFactory);
        windowsApp.Run();
    }
}
