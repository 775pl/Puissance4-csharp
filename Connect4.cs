using System;
using System.Collections.Generic;
using System.Text;

namespace Puissance4
{
    class Connect4
    {

        private int PlayerNumber = 1;
        private int turns = 0;
        private readonly Direction[] directions = {
            new Direction(left: 0, right: 4, top: 0, bottom: 5, dx: 1, dy: 0),
            new Direction(left: 0, right: 4, top: 0, bottom: 2, dx: 1, dy: 1),
            new Direction(left: 0, right: 6, top: 0, bottom: 2, dx: 0, dy: 1),
            new Direction(left: 4, right: 4, top: 0, bottom: 2, dx: -1, dy: 1)
        };

        public const int lineCount = 6;
        public const int colCount = 7;

        private char[,] grid = new char[colCount? lineCount];

        public Connect4(){
            for(var col=0; col < grid.GetLength(0); col++){
                for(var line=0, line < grid.GetLength(1)); line++){
            
                    grid[col, line] = ' ';
                }
                    
            }
            
        }
                
                    
                    
                    }
        // TODO : Compléter cette classe pour implémenter les règles du puissance 4
        // TODO : Utiliser un tableau à deux dimensions
        public char getPawn(int col, int line) => grid[col,line];

        public int PlayerNumber => playerNumber;

        public void Play(int column){
            
            int i;
            column--;
            for(i = 0; i < lineCount; i++){

                if(grid[column, i] != ' '){

                    if(i==0)}{
                        throw new ArgumentException("Bad column number : The colum is full");
                    }else {
                        break;
                    }
                    
                        
            }
                
                    
                    }if(playerNumber == 1){
                        grid[column, i - 1] = 'x';
                    }else{

                        grid[column, i - 1] = 'o';
                    }

                    for(var col = 0; col < grid.GetLength(0); col++){
                        for(var line = 0; line < grid.GetLength(1), line++){
                            var pawn = GetPawn(col, line);
                                if(pawn != ' '){
                                    foreach(var dir in directions){
                                        if(dir.AreALigned(pawn, grid, col, line)){
                                            winner = playerNumber;
                                        }
                                    }
                        }
}


        public int Winner => 0;
        public bool Ended => turns == LineCount*ColCount;
        public bool Ended => false;

        private class Direction{
            private readonly int _left, _right, _top, _bottom, _dx, _dy; 

            public Direction(int left, int right, int top, int bottom, int dx, int dy){
                _left = left;
                _right = right;
                _top = top;
                _bottom = bottom;
                _dx = dx;
                _dy = dy;
            }
            public bool MustCheck(int col, int line){
                return _left <=col col && col <= _right
                && _top <= line && line <= _bottom;
        }  
            public bool

}
    }
}
