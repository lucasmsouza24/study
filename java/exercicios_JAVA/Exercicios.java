import java.util.ArrayList;

public class Exercicios {
    // Exercício 01
    static void ex01(int n1, int n2) {
        int soma = n1 + n2;
        System.out.println(soma);
    }

    // Exercício 02
    static void ex02(int number) {
        for (int i = number; i != -1; i--) {
            System.out.println(i);
        }
    }

    // Exercício 03
    static void ex03(){
        int odds_sum = 0;
        long evens_mult = 1;
        for (int i = 1; i <= 30; i++) {
            if (i % 2 == 0) {
                evens_mult = evens_mult * i;
            } else {
                odds_sum += i;
            }
        }
        String text = "odds sum: " + Integer.toString(odds_sum) + "\nevens mult: " + Long.toString(evens_mult);
        System.out.println(text);
    }

    // Exercício 04
    static void ex04(int numA, int numB) {
        int temp = numA;
        numA = numB;
        numB = temp;
        String text = "NumA: " + Integer.toString(numA) + "\nnumB: " + Integer.toString(numB);
        System.out.println(text);
    }

    // Exercício 05
    static void ex05(int n1, int n2){
        if (n1 == n2) {
            System.out.println(n1 + " = " + n2);
        } else if (n1 > n2) {
            System.out.println(n1 + " > " + n2);
        } else {
            System.out.println(n2 + " > " + n1);
        }
    }

    // Exercício 06
    static class MediaAluno {
        ArrayList<Integer> notes = new ArrayList<Integer>();

        public void addNote(int note) {
            if (note >= 0 && note <= 100) {
                this.notes.add(note);
                System.out.println("Nota adicionada com sucesso: " + note);
            } else {
                System.out.println("Valor invalido: " + note);
            }
        }
    }

    // Exercício 07
    static class Contato {
        public Contato(String nome, String email) {
            this.nome = nome;
            this.email = email;
        }
        String nome;
        String email;

        public String getName() {
            return this.nome;
        }
    }

    static class Agenda {

        public Agenda() {
            this.contatos = new ArrayList<Contato>();
        }

        ArrayList<Contato> contatos;

        public void addContato(String nome, String email) {
            this.contatos.add(new Contato(nome, email));
        }

        public ArrayList<Contato> getContatos() {
            return this.contatos;
        }
    }
    
    // Main Class -> apenas p executar os exercícios
    public static void main(String[] args) {
        // ex01(5, 4); // Ex 01
        // ex02(100); // Ex 02
        // ex03(); // Ex 03
        // ex04(4, 8); // Ex 04
        // ex05(30, 30); // Ex 05
        
        // Ex 06
        // MediaAluno aluno1 = new MediaAluno();
        // aluno1.addNote(58);
        // aluno1.addNote(85);
        // aluno1.addNote(32);
        // aluno1.addNote(460);
        // aluno1.addNote(200);
        // aluno1.addNote(3);
        // System.out.println(aluno1.notes);   

        // Ex 07 (Não terminei)

        // Contato pessoa1 = new Contato("Luquinha", "lucas.msouza@senacsp.edu.br");
        // System.out.println(pessoa1.nome);
        // System.out.println(pessoa1.email);

        // Agenda ag1 = new Agenda();
        // ag1.addContato("Cledinha", "cleide.smesquita@gmail.com");
        // ag1.addContato("lucas", "lucas.msouza24@gmail.com");
        // System.out.println(ag1.getContatos());

        ArrayList<Contato> myArray = new ArrayList<Contato>();
        myArray.add(new Contato("luquinha", "luquinha@gmail.com"));
        myArray.add(new Contato("Bob", "bobdylan@gmail.com"));
        System.out.println(myArray[0]);

    }
}