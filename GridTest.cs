using System;

namespace Sudoku2
{
	public class GridTest
	{	
		private Grid g = new Grid();
	
		public void validGridTest()
		{
            Console.WriteLine();
            Console.WriteLine("--TEST GRILLE VALIDE--");
            Console.WriteLine();
            
    		
			int[,] grid = { {1,2,3,7,8,9,4,5,6},
            				{4,5,6,1,2,3,7,8,9},
            		 		{7,8,9,4,5,6,1,2,3},
            				{2,3,1,8,9,7,5,6,4},
            				{5,6,4,2,3,1,8,9,7},
            			    {8,9,7,5,6,4,2,3,1},
            				{3,1,2,9,7,8,6,4,5},
            				{6,4,5,3,1,2,9,7,8},
            				{9,7,8,6,4,5,3,1,2} };
            				
            Console.WriteLine(g.isGridValid(grid));
		}
		
		public void gridValeurInterdite()
		{
            Console.WriteLine();
            Console.WriteLine("--TEST GRILLE NON VALIDE : VALEUR INTERDITE--");
            Console.WriteLine();
            
    		
			int[,] grid = { {1,2,3,7,8,9,4,5,6},
            				{4,5,6,1,2,3,7,8,9},
            				{7,8,9,4,5,6,1,2,3},
            				{2,3,1,8,9,7,5,6,4},
            				{5,6,4,2,3,1,8,9,7},
            				{8,9,7,5,6,4,2,3,1},
            				{3,1,2,9,0,8,6,4,5},
            				{6,4,5,3,1,2,9,7,8},
            				{9,7,8,6,4,5,3,1,2} };
            				
            Console.WriteLine(g.isGridValid(grid));
		}
				
		public void gridMauvaisesDimensions()
		{
            Console.WriteLine();
            Console.WriteLine("--TEST GRILLE NON VALIDE : MAUVAISES DIMENSIONS--");
            Console.WriteLine();
            
    		
			int[,] grid = { {1,2,3,7,8,9,4,5},
            				{4,5,6,1,2,3,7,8},
            				{7,8,9,4,5,6,1,2},
            				{2,3,1,8,0,7,5,6},
            				{5,6,4,2,3,1,8,9},
            				{8,9,7,5,6,4,2,3},
            				{3,1,2,9,7,8,6,4},
            				{6,4,5,3,1,2,9,7},
            				{9,7,8,6,4,5,3,1} };
            				
            Console.WriteLine(g.isGridValid(grid));
		}
		
		public void gridValeurDouble()
		{
            Console.WriteLine();
            Console.WriteLine("--TEST GRILLE NON VALIDE : VALEUR DOUBLE--");
            Console.WriteLine();
            
    		
			int[,] grid = { {1,2,3,7,8,9,4,5,6},
            				{4,5,6,1,2,3,7,8,9},
            				{7,8,9,4,5,6,1,2,3},
            				{2,3,1,8,9,7,5,6,4},
            				{5,6,4,2,3,1,2,5,7},
            				{8,9,7,5,6,4,8,3,1},
            				{3,1,2,9,7,8,6,4,5},
            				{6,4,5,3,1,2,9,7,8},
            				{9,7,8,6,4,5,3,1,2} };
            				
            Console.WriteLine(g.isGridValid(grid));
		}
		
		
		public void gridBlocInvalide()
		{
            Console.WriteLine();
            Console.WriteLine("--TEST GRILLE NON VALIDE : BLOC INVALIDE--");
            Console.WriteLine();
            
    		
			int[,] grid = { {1,2,3,4,5,6,7,8,9},
            				{2,3,4,5,6,7,8,9,1},
            				{3,4,5,6,7,8,9,1,2},
            				{4,5,6,7,8,9,1,2,3},
            				{5,6,7,8,9,1,2,3,4},
            				{6,7,8,9,1,2,3,4,5},
            				{7,8,9,1,2,3,4,5,6},
            				{8,9,1,2,3,4,5,6,7},
            				{9,1,2,3,4,5,6,7,8} };
            				
            Console.WriteLine(g.isGridValid(grid));
		}
		public void runAllTests()
		{
			validGridTest();
			gridValeurInterdite();
			gridMauvaisesDimensions();
			gridValeurDouble();
			gridBlocInvalide();
		}
	}
}