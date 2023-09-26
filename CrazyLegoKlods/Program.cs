

using System.Xml.Schema;

class LegoKlods
{
    #region Fields

    int _xValue;
    int _yValue;   
    bool _isVertical;

    #endregion

    #region Constructor

    public LegoKlods(int xValue, int yValue)
    {
        _xValue = xValue;
        _yValue = yValue;

        _isVertical = false;


    }


    #endregion

    #region Properties

    /// <summary>
    /// property brugt til at få værdien på _xValue så vi kan bruge den når vi tester.
    /// den har en sætter så den kan bruges til at give en værdi også ved : LegoKlods.XValue = (ny x værdi)
    /// LegoKlods her er vores konstruktor, som skal betyde fremtidige objekter vi laver( aka. instantiater)
    /// </summary>
    public int XValue
    {
        get { return _xValue; }
        set { _xValue = value; }
    }



    /// <summary>
    /// det samme som XValue, men med Y-værdien
    /// </summary>
    public int YValue
    {
        get { return _yValue; }
        set { _yValue = value; }
    }


    /// <summary>
    /// det samme som Y og X-Værdierne, men denne gang med vores bool
    /// </summary>
    public bool IsVertical
    {
        get { return _isVertical; }
    }



    #endregion

    #region Methods





    /// <summary>
    /// roter legoklodes
    /// hvis metoden bliver kaldet sætter den _isVertical til det modsatte af hvad den er.
    /// </summary>
    public void RotateLego() { _isVertical = !_isVertical; }




    /// <summary>
    /// giver nye x og y værdier
    /// </summary>


    public void SetPosition(int xValue, int yValue)
    {
        _xValue = xValue;
        _yValue = yValue;

    }

    /// <summary>
    /// alternativ til SetPosition
    ///brug 2 int istedet for 1 int (int, int) i stedet for 'int'.
    ///fordi vi skal have 2 forskellige 'int' tilbage, med en normal 'int', får vi kun en 'int' tilbage på vores return
    /// </summary>
    public (int, int) SetPositionAlternative(int x, int y)
    {

        _xValue = x;
        _yValue = y;

        return (_xValue, _yValue);

    }



    /// <summary>
    /// gå op eller ned
    /// </summary>

    public void GoUp()
    {
        // _yValue--; er det samme som _yValue = _yValue - 1;
        // for at gå op skal vi tættere på 0, det gør vi ved at _yValue--; ikke _yvalue++;
        _yValue--;
    }

    public void GoDown()
    {
        _yValue++;
    }


    /// <summary>
    /// når metoderne bliver kaldet skal de gøre som beskrevet i navenet
    /// </summary>

    public void GoLeft()
    {

        // for at gå venstre skal vi gå mod 0, derfor _xValue--;
        _xValue--;
    }
    public void GoRight()
    {
        _xValue++;
    }


    /// <summary>
    /// print x og y
    /// </summary>
    public void PrintXAndY()
    {


        Console.WriteLine(Math.Abs(XValue) % 10);
        Console.WriteLine(Math.Abs(YValue) % 10);

    }

    // efter note: jeg bruger math.Abs for at få et positivt tal, og '% 10' for at det ikke kan blive mere end 10.
    // det er ikke en anbefalet måde at sætte grænser på men i det her eksempel er det godtageligt.

    // '%' eller modolus, er den resterende værdi af 2(eller flere) tal, fx. 25 % 9 = 7

    #endregion
}



