using System;

namespace calculadoraRm;

public partial class MainPage : ContentPage
{

    int actualNum = 1;
    string operationCalc;
    double firstNum, secNum;
    string numberSelected;
    double number;
    public MainPage()
	{
		InitializeComponent();
        ClearButton(this, null);

	}

    public void ClearButton(object sender, EventArgs e)
    {
        firstNum = 0;
        secNum = 0;
        actualNum = 1;
        this.result.Text = "0";
    }

 public void Button_Clicked(object sender, EventArgs e)
    {
        actualNum = -2; //para resetear el numero mostrado y que se pueda digitar 2nd num para hacer operacion
        Button button = (Button)sender;
        string btnOperator = button.Text;
        operationCalc = btnOperator;
    }

public void CalculateOperation(object sender, EventArgs e)
    {
        if(actualNum == 2)
        {
            //metodo para hacer operaciones por medio de un case en operators.
            var result = Operators.CalculateOperators(firstNum, secNum, operationCalc);

            this.result.Text = result.ToString();
            firstNum = result;
            actualNum = -1; //para resetear el numero mostrado
           
        }
    }

    public void SelectNumber(object sender, EventArgs e)
    {
     
        Button button = (Button)sender;
        string btnSelected = button.Text;
        //si el numero en pantalla es 0 o numero digitado es menor a 0, metodo empty rellena result de pantalla
        if(this.result.Text == "0" || actualNum < 0)
        {
            this.result.Text = string.Empty;
            if(actualNum < 0)
                
                actualNum *= -1;
        }
        //agrega el num seleccionado en pantalla
        this.result.Text += btnSelected;

        //convierte el string del numero digitado a double para las operaciones
        if(double.TryParse(this.result.Text, out number))
        {
            this.result.Text = number.ToString("N0"); //formato To.string("N0") redondea el numero sin decimales.
            if(actualNum == 1)
            {
                firstNum = number;
            }
            else
            {
                secNum = number;
            }
        }
    }
}

    
    
    

