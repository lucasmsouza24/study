import java.util.Scanner;
import java.util.ArrayList;

class Ex18 {
    public static void main(String[] args) {
        // scanner object instance
        Scanner input = new Scanner(System.in);

        // read values
        System.out.println("Valor 1: ");
        Double a = input.nextDouble();
        System.out.println("Valor 2: ");
        Double b = input.nextDouble();
        System.out.println("Valor 3: ");
        Double c = input.nextDouble();

        // ordering values on array
        ArrayList<Double> tri = new ArrayList<Double>();

        if (a >= b && a >= c){
            tri.add(a);
            if (b >= c) {
                tri.add(b);
                tri.add(c);
            } else {
                tri.add(c);
                tri.add(b);
            }
        } else if (b >= a && b >= c) {
            tri.add(b);
            if (a >= c){
                tri.add(a);
                tri.add(c);
            } else {
                tri.add(c);
                tri.add(a);
            }
        } else {
            tri.add(c);
            if (a >= b) {
                tri.add(a);
                tri.add(b);
            } else {
                tri.add(b);
                tri.add(a);
            }
        }

        System.out.println(tri);
        
        // Case 1: done
        if (tri.get(0) >= tri.get(1) + tri.get(2)){
            System.out.println("NAO FORMA TRIANGULO");
        } else {
            // Case 2: done
            if (tri.get(0) * tri.get(0) == (tri.get(1) * tri.get(1)) + (tri.get(2) * tri.get(2))) {
                System.out.println("TRIANGULO RETANGULO");
            }

            // Case 3: done
            if (tri.get(0) * tri.get(0) > (tri.get(1) * tri.get(1)) + (tri.get(2) * tri.get(2))) {
                System.out.println("TRIANGULO OBTUSANGULO");
            }

            // Case 4: done
            if (tri.get(0) * tri.get(0) < (tri.get(1) * tri.get(1)) + (tri.get(2) * tri.get(2))) {
                System.out.println("TRIANGULO ACUTANGULO");
            }
            // Case 5: done
            if (tri.get(0) == tri.get(1) && tri.get(1) == tri.get(2)) {
                System.out.println("TRIANGULO EQUILATERO");
            } 
            // Case 6: done
            else if (tri.get(0) == tri.get(1) || tri.get(1) == tri.get(2) || tri.get(0) == tri.get(2)){
                System.out.println("TRIANGULO ISOCELES");
            }
        }
    }
}