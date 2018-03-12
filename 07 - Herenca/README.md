# Heranca 

## M�todos de acesso  
### Encapsulamento  
 M�todos herdados recebem palavra reservada override  
```c#
 
  public override void Exemplo(int valor)
  {
  }
```
 M�tods base recebem palavra reservada virtual
```c#
 
  public virtual void Exemplo(int valor)
  {
  }
```
Em C# a heran�a garante que acesso as propriedades e m�todos com excess�o do m�todo construtor.  
Para acessasr m�todo construtor precisamos de:
```c#
public ContaPoupanca() : base() { }
        public ContaPoupanca(int numero, double valor) : base(numero, valor) { }
```