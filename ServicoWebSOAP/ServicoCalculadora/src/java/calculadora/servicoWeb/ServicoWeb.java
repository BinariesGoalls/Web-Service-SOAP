package calculadora.servicoWeb;

import javax.jws.WebService;

@WebService(serviceName = "ServicoWeb")
public class ServicoWeb {

    
    public double soma(double num1, double num2) {
        
        return num1 + num2;
        
    }
}
