using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PaintBefore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



        }
    }

    public interface IMemento
    {
        object State { get; set; } 
    }

    public class InkCanvasWithUndo: InkCanvas
    {
        public IMemento CreateMemento()
        {
            Stroke[] copy = Strokes.ToArray();
            return new InkCanvasMemento {State = copy};
        }

        public void SetMememto(IMemento memento)
        {
            Strokes = new StrokeCollection((Stroke[])memento.State);
        }

        public class InkCanvasMemento : IMemento
        {
            #region IMemento Members

            public object State { get; set; }

            #endregion
        }
    }

    
}
