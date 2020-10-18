import java.util.Scanner;


public class Main
{
	public static void main(String[] args) {
        Scanner teclado = new Scanner(System.in);
        
        System.out.println("BEM VINDO AO MENU DO JOGO\n");
        
        System.out.println("SELECIONE UMA DAS OPÇÃO ABAIXO: \n");
        
        System.out.println(" A) INSTRUÇÕES\n B) JOGAR\n C) CRÉDITOS\n D) SAIR");
        String opcao = teclado.next();
        
        opcao = opcao.toUpperCase();
        
        boolean saiu = false;
        
        do{
            
            switch (opcao){
                case ("A"):
                    System.out.println("BEM VINDO AS INSTRUÇÕES DO JOGO!\n PARA JOGAR APERTE EM PLAY E BOM JOGO!");
                    break;
            
                case ("B"):
                    System.out.println("BEM VINDO A SUMMONER'S RIFT!");
                    break;
               
                case ("C"):
                    System.out.println("ESSE JOGO FOI DESENVOLVIDO POR 'TRYNDAMERE' MERRILL e BRANDON 'RYZE'!");
                    break;
                    
                case ("D"):
                    System.out.println("VOCÊ ESCOLHEU SAIR!");
                    saiu = true;
                    break;
                
                default:
                    System.out.println("OPCAO INVALIDA");
            }
            
            System.out.println("\n A) INSTRUCOES\n B) JOGAR\n C) CREDITOS\n D) SAIR");
            opcao = teclado.next();
            opcao = opcao.toUpperCase();
            
	    }while(!saiu);
	        System.out.println("ATE BREVE!");
    }
}

