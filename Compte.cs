using System;
using System.Collections.Generic;

namespace DAB2
{
    public class Compte
    {
    	private float solde;
    
    	private List<Transaction> transactions = new List<Transaction>();
    	
    	private int montantMax = 1000;
    	
    	public Compte(int mt)
    	{
    		montantMax = mt;
    	}
    	
    	public float getSolde()
    	{
    		return solde;
    	}
    	
    	public void updateSolde(float s)
    	{
    		solde += s;
    	}
    	
    	public List<Transaction> getTransactions()
    	{
    		return transactions;
    	}
    	
    	public int getMontantMax()
    	{
    		return montantMax;
    	}
    	
    	public void addTransaction(DateTime dt, float montant)
    	{
    		solde += montant;
    		transactions.Add(new Transaction(dt, montant));
    	}
    	
    }
}