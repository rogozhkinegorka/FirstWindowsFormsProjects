using System;

public class Class1
{
    string chislo;
	public Class1(string dvoich)
	{
        this.chislo = dvoich;
	}
    public string Perevod(int SS)
    {
        return Convert.ToString(Convert.ToInt32(chislo, 2), SS);
        return "kaput";
    }
}
