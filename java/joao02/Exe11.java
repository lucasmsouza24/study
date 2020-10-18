import java.util.Scanner;

public class Exe11 {public static void main(String[] args) {
        Scanner teclado = new Scanner(System.in);
        
        int nDigitado;
        double divisao, soma = 0, resultado = 0, i;
        boolean controle = true;
        
            System.out.println("Digite um numero: ");
            nDigitado = teclado.nextInt();
            
            for(i=1; i <= nDigitado; i++){
                
                if(controle == true){
                    divisao = 1 / i;
                    soma = soma + divisao;
                    resultado = resultado + soma;
                    controle = false;
                }else{
                    divisao = 1 / i;
                    soma = soma - divisao;
                    resultado = resultado + soma;
                    controle = true;
                } 
            }System.out.println(soma);
    }
}