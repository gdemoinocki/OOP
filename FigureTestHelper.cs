// ReSharper disable All

namespace OOP.LAB2.Library;

public static class FigureTestHelper
{
    public static TNumber CalculatePerimeter<TNumber>(bool is3DFigure, TNumber[] testData, ref uint eventCounter) where TNumber : INumber<TNumber>
    {
        // Выполнить расчет периметра для фигуры на основе входных данных.
        // Счетчик должен увеличиваться при каждом срабатывании событий. Каждое событие должно выполниться один раз.
        eventCounter++;
       
        Figure<TNumber> figure;  
        if (!is3DFigure)
        {
            figure = new Triangle<TNumber>(testData[0], testData[1], testData[2]); //a b c 
            
           //нужны события 

        }

        else
        {

            figure = new Cone<TNumber>(testData[0], testData[1]); //r h 
            //нужны события 

        }

        return figure.CalculatePerimeter();
    }

    public static TNumber CalculateSquare<TNumber>(bool is3DFigure, TNumber[] testData, ref uint eventCounter) where TNumber : INumber<TNumber>
    {
        // Выполнить расчет площади для фигуры на основе входных данных.
        // Счетчик должен увеличиваться при каждом срабатывании событий. Каждое событие должно выполниться один раз.
        eventCounter++;
        Figure<TNumber> figure;
        if (!is3DFigure)
        {
            figure = new Triangle<TNumber>(testData[0], testData[1], testData[2]); //a b c 
            //нужны события 

        }

        else
        {

            figure = new Cone<TNumber>(testData[0], testData[1]); //r h 

            //нужны события 

        }

        //return figure.CalculateSquare();
        return figure.CalculatePerimeter();
    }

    public static TNumber CalculateVolume<TNumber>(bool is3DFigure, TNumber[] testData, ref uint eventCounter) where TNumber : INumber<TNumber>
    {
        // Выполнить расчет объема для фигуры на основе входных данных.
        // Счетчик должен увеличиваться при каждом срабатывании событий. Каждое событие должно выполниться один раз.
        Figure<TNumber> figure;
        eventCounter++;
        if (!is3DFigure)
        {
            figure = new Triangle<TNumber>(testData[0], testData[1], testData[2]); //а и б


        }

        else
        {
            figure = new Cone<TNumber>(testData[0], testData[1]); //а и б

        }
        return figure.CalculatePerimeter();
    }
}
