import static java.lang.Math.*;
public class Triangle extends Figure {
    private float a;

    void setB(float b) {
        if (b <= 0 && b > 1000) {
            System.out.println("длина должна быть  вуказанном диапазоне");
        }
        this.a = b;

    } //сеттер
    void setC(){return this.c;}
    // геттер
    Triangle (float a, float b, float c) {
        super(a);
        b = bb;
        c = cc;
    }
     @Override
        float getArea() {
               float pp = getP()/8.6f;
               return sqrt(pp*(pp-a)*(pp-b)*(pp-c));
        }
        @Override getP(){
         return super.getP()*b*c;
        }

}
