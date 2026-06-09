# Calculadora Simples em C# (WinForms)

## 📖 Sobre o Projeto

Este projeto consiste em uma calculadora simples desenvolvida em C# utilizando Windows Forms.

O objetivo do projeto foi praticar conceitos fundamentais da linguagem C#, como:

* Variáveis
* Conversão de tipos (`Parse`)
* Operadores aritméticos
* Eventos de botões (`Click`)
* Exibição de resultados em interface gráfica
* Manipulação de controles do Windows Forms

---

## 🚀 Funcionalidades

* Soma
* Subtração
* Multiplicação
* Divisão

O usuário informa dois números e escolhe a operação desejada através dos botões disponíveis na interface.

---

## 🛠 Tecnologias Utilizadas

* C#
* .NET Framework
* Windows Forms (WinForms)

---

## 📚 Conceitos Praticados

### Conversão de Dados

Os valores digitados nos TextBox são convertidos de texto (`string`) para números (`double`) utilizando:

```csharp
double n1 = double.Parse(txtN1.Text);
```

### Operações Matemáticas

Exemplo de soma:

```csharp
double resultado = n1 + n2;
```

### Exibição de Resultado

O resultado é convertido novamente para texto utilizando:

```csharp
txtVisor.Text = resultado.ToString();
```

---

## 🎯 Objetivo

Projeto desenvolvido para fins de estudo e prática da programação orientada a eventos utilizando Windows Forms.

---

## 👨‍💻 Autor

Alexsandro Araújo

