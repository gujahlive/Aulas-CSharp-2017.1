# Heranca 

## Métodos de acesso  
### Encapsulamento  
 Métodos herdados recebem palavra reservada override  
```c#
 
  public override void Exemplo(int valor)
  {
  }
```
 Métods base recebem palavra reservada virtual
```c#
 
  public virtual void Exemplo(int valor)
  {
  }
```
Em C# a herança garante que acesso as propriedades e métodos com excessão do método construtor.  
Para acessasr método construtor precisamos de:
```c#
public ContaPoupanca() : base() { }
        public ContaPoupanca(int numero, double valor) : base(numero, valor) { }
```