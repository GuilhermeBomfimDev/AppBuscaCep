# 🧠 Busca Inteligente de Endereços com Integração de IA

![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![AI](https://img.shields.io/badge/IA%20Integrada-%2300A67E?style=for-the-badge)
![API](https://img.shields.io/badge/API%20REST-F05032?style=for-the-badge)
![JSON](https://img.shields.io/badge/JSON-000000?style=for-the-badge&logo=json&logoColor=white)

## 📌 Sobre o Projeto
Este projeto é uma aplicação **Windows Forms** desenvolvida em **C# (.NET)** que realiza buscas de endereços com base em informações fornecidas pelo usuário, utilizando **Integração com Inteligência Artificial** para interpretar frases e construir automaticamente a URL da API de consulta.

A aplicação faz uso da **API ViaCEP** para retornar dados detalhados como:
- CEP  
- Logradouro  
- Bairro  
- Cidade  
- UF  
- Estado  
- Região  
- DDD  

---

## 🚀 Funcionalidades Principais
✅ **Busca Inteligente com IA** – O usuário pode digitar frases como _"Rua Tirol, Belo Horizonte, MG"_ e a IA extrai automaticamente o **Estado**, **Cidade** e **Rua** no formato correto.  
✅ **Formatação Automática de URL** – A IA retorna a URL pronta no padrão da API do ViaCEP.  
✅ **Interface Amigável** – Uso de **ListView** com colunas pré-definidas para exibição dos resultados.  
✅ **Mensagens de Carregamento** – O sistema exibe um **MessageBox** enquanto busca os dados, melhorando a experiência do usuário.  
✅ **Tratamento de Erros** – Validação de entradas e mensagens claras quando o endereço não é encontrado.  

---

## 🛠 Tecnologias Utilizadas
- **C#** (.NET 8.0 / Windows Forms)
- **Integração com IA** para extração de dados
- **API REST** ([ViaCEP](https://viacep.com.br))
- **JSON** (Serialização/Deserialização com `Newtonsoft.Json`)
- **Async/Await** para chamadas assíncronas
- **ListView com ColumnHeader** para tabela organizada

---

## 📂 Estrutura Simplificada do Código
```csharp
// Exemplo de como a IA monta a URL:
string promptBuscaIA = $"A partir da frase abaixo, extraia Estado, Cidade e Rua (somente nome, sem prefixos como Av. ou Rua). 
Retorne SOMENTE no formato: https://viacep.com.br/ws/UF/Cidade/Rua/json/. 
Frase: '{texto}'";

// Busca assíncrona na API
HttpResponseMessage response = await client.GetAsync(url);
var json = await response.Content.ReadAsStringAsync();
List<CepDados> enderecos = JsonConvert.DeserializeObject<List<CepDados>>(json);

📌 Observações
--------------

- O sistema usa IA para interpretar endereços, então a precisão depende da clareza da frase fornecida.  
- Caso queira adaptar para outros formatos de API, basta ajustar o prompt e a lógica de construção da URL.

---

👨‍💻 Autor
----------

**Guilherme Bomfim**  
💼 [LinkedIn](https://www.linkedin.com/in/guilherme-bomfim-7a87aa295/)  
📂 [Portfólio no GitHub](https://github.com/GuilhermeBomfimDev)
