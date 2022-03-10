using System;
using System.Collections.Generic;

namespace DAB2
{
    public class Dab : IDab
    {
    	private static readonly int printNumber = 10; //Nombre de transactions à afficher
    	
    	private Compte compte;
    	
    	public Dab(Compte c)
    	{
    		compte = c;
    	}
    	
    	public void print()
    	{
    		Console.WriteLine("Le solde du compte est de : " + compte.getSolde() + " euros.");
    		Console.WriteLine("La liste des " + printNumber + " dernieres transactions : ");
    		
    		int cmpt = 0;
    		
    		for(int i=compte.getTransactions().Count-1; i>=0; i--)
    		{
    			if(cmpt > printNumber)
    			{
    				break;
    			}
    			Console.WriteLine(compte.getTransactions()[i].getDate().ToString("d") + " : " + compte.getTransactions()[i].getValeurTransaction());
				cmpt++;
    		}
    	}
    	
    	public void depot(DateTime dt, float montant)
    	{
    		compte.addTransaction(dt, montant);
    		
    		Console.WriteLine(dt.ToString("d") + " : Un depot de " + montant + " a ete effectue.");
    		Console.WriteLine("Le solde du compte est de : " + compte.getSolde() + " euros.");
    	}
    	    	
    	public void depot(float montant)
    	{
    		depot(DateTime.Now, montant);
    	}
    	
    	public void retrait(DateTime dt, float montant)
    	{
    		if(compte.getSolde() - montant < 0)
    		{
    			Console.WriteLine(dt.ToString("d") + " : Le solde (" + (compte.getSolde()) + " euros)  est insuffisant pour le retrait de " + montant + " euros.");
    			return;
    		}
    		
    		float montantUtilise = 0;
    		for(int i=compte.getTransactions().Count-1; i>=0; i--)
    		{    		
    			//On ne regarde que les 30 derniers jours	
    			//et les transactions negatives pour le calcul du plafond
    			if(Math.Abs(dt.Subtract(compte.getTransactions()[i].getDate()).Days) < 30  &&  compte.getTransactions()[i].getValeurTransaction() < 0) 
    			{
    				montantUtilise -= compte.getTransactions()[i].getValeurTransaction(); 
    			}
    		} 
    		
    		if(montantUtilise + montant > compte.getMontantMax())
    		{
    			Console.WriteLine(dt.ToString("d") + " : Le plafond (" + (compte.getMontantMax() - montantUtilise) + " euros) est insuffisant pour le retrait de " + montant + " euros.");
    			return;
    		}
    		else {
    			compte.addTransaction(dt, -montant);
    			
    			Console.WriteLine(dt.ToString("d") + " : Un retrait de " + montant + " a ete effectue.");
    			Console.WriteLine("Le solde du compte est de : " + compte.getSolde() + " euros.");
    		}    		
    	}
    	
    	public void retrait(float montant)
    	{
    		retrait(DateTime.Now, montant);
    	}	
    }
}