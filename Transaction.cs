using System;
using System.Collections.Generic;

namespace DAB2
{
    public class Transaction
    {
    	public DateTime date;
    	
    	public float valeurTransaction;
    
    	public Transaction(DateTime d, float vt)
    	{
    		date = d;
    		valeurTransaction = vt;
    	}
    	
    	public DateTime getDate()
    	{
    		return date;
    	}
    	
    	public void setDate(DateTime dt)
    	{
    		date = dt;
    	}
    	
    	public float getValeurTransaction()
    	{
    		return valeurTransaction;
    	}
    }
}