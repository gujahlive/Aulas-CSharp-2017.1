# Encapsulamento e Modificadores de acesso

## Contexto

Conta.cs

```C#
	class Conta{

	public String titular;
	private double saldo;
	public int numeroConta;

		public double consultarSaldo(){
			return this.saldo;
		}
		
		public void sacar(double valor){
			this.saldo -= valor;
		}
		

	
	}

```

Program.cs
```C#
	Conta c1 = new Conta();
	c1.titular = "Gelton Cruz";
	c1.numeroConta = 0001;
	c1.saldo = 1000;

	c1.consultarSaldo();
	// Retornará 1000

	c1.sacar(300);


```

### Encapsulamento
Public - Acesso público por todas as classes e metodos
Protected - Acesso concedido apenas a si e seus herdeiros
private  - Acesso exclusivo da classe

### Controle de acesso
