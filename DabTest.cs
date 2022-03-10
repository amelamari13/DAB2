using System;
using System.Collections.Generic;

namespace DAB2
{
    public class DabTest
    {
        private Dab d;
        
        private Compte c;
        
        public DabTest()
        {
        	init();
        }
        
    	private void init()
    	{
    		c = new Compte(100);
    		d = new Dab(c);
    	}
    	
    	public void printTest()
    	{   	
            Console.WriteLine();
            Console.WriteLine("--TEST PRINT--");
            Console.WriteLine();
            
            d.depot(new DateTime(2022,03,07), 3000);
            d.retrait(new DateTime(2022,03,08), 60);
            d.depot(new DateTime(2022,03,10), 40);
            d.depot(new DateTime(2022,03,10), 16);
            d.retrait(new DateTime(2022,03,12), 95);
            d.retrait(new DateTime(2022,03,12), 26);
            d.depot(new DateTime(2022,03,14), 150);
            d.depot(new DateTime(2022,03,20), 30);
            d.retrait(new DateTime(2022,03,21), 6);
            d.depot(new DateTime(2022,03,22), 55);
            d.retrait(new DateTime(2022,03,23), 12);
            d.retrait(new DateTime(2022,03,25), 48);
            
            Console.WriteLine();
            
            d.print();
    	}
    	
    	public void depotTest()
    	{   
            Console.WriteLine();
            Console.WriteLine("--TEST DEPOT--");
            Console.WriteLine(); 	
            	
    		d.depot(new DateTime(2022,03,28), 30);
    	}
    	
    	
    	
    	public void retraitTestSoldeInsuffisant()
    	{
            Console.WriteLine();
            Console.WriteLine("--TEST RETRAIT SOLDE INSUFFISANT--");
            Console.WriteLine();
            
    		d.retrait(new DateTime(2022,03,28), 11000);
    	}
    	
    	public void retraitTestPlafondInsuffisant()
    	{
            Console.WriteLine();
            Console.WriteLine("--TEST RETRAIT PLAFOND INSUFFISANT--");
            Console.WriteLine();
              		
    		d.retrait(new DateTime(2022,03,30), 120);
    	}
    	
    	public void runAllTests()
    	{
    		printTest();
    		depotTest();
    		retraitTestSoldeInsuffisant();
    		retraitTestPlafondInsuffisant();
    	}
    }
}