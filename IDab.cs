using System;

namespace DAB2
{
    public interface IDab
    {
    	void print();
    	
    	void depot(float montant);
    	
    	void retrait(float montant);
    }
}