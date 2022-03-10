using System;
using System.Collections.Generic;

namespace Sudoku2
{
    class Grid
    {
    	private int[] authorizedValues = {1,2,3,4,5,6,7,8,9};
    	
    	private static readonly int dim = 9;
    	
    	private static readonly int blockDim = 3;
    	
    	public bool isLineValid(int[] values)
    	{
    		HashSet<int> numbers = new HashSet<int>();			
			foreach(var i in values)
			{
				if(Array.Exists(authorizedValues, x => x == i))
				{	 
					numbers.Add(i);
				}
			}
			return (numbers.Count == dim);
    	}
    	
    	public int[] getBlockAtIndexAsLine(int index, int[,] g)
    	{
    		int[] block = new int[dim];
    		
    		int row = (index/3)*3;
			int col = (index%3)*3;
			
			int cmpt=0;
			for(int i=0; i<blockDim; i++)
			{
				for(int j=0; j<blockDim; j++)
				{
					block[cmpt++] = g[row, col];
					col = col+1;
				}
				row = row+1;
				col = (index%3)*3;
			}
			
			return block;
    	}
    	
    	public bool isGridValid(int[,] grid)
    	{    		
    		if(grid.GetLength(0) != dim || grid.GetLength(1) != dim)
    		{
    			return false;
    		}
    		
    		int[] l = new int[dim];
    		for(int i=0; i<dim; i++)
    		{	    		
    			int[] c = new int[dim];
    			for(int j=0; j<dim; j++)
    			{
    				l[j] = grid[i,j];
    				c[j] = grid[j,i];
    			}    			
    			if(!(isLineValid(l) && isLineValid(c) && isLineValid(getBlockAtIndexAsLine(i, grid)))){
    				return false;
    			}	
    		}
    		return true;
    	}
    }
}   