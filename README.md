# Observer Pattern
O Observer é um padrão de projeto que permite que você defina um mecanismo de assinatura para notificar múltiplos objetos sobre quaisquer eventos que aconteçam com o objeto que eles estão observando. Permite que objetos interessados sejam avisados da mudança de estado ou outros eventos ocorrendo num outro objeto.
O padrão Observer é também chamado de Publisher-Subscriber, Event Generator e Dependents. 

***
## Aplicabilidade
O padrão Observer pode ser usado quando mudanças no estado de um objeto podem precisar mudar outros objetos, e o atual conjunto de objetos é desconhecido de antemão ou muda dinamicamente.
 
O padrão Observer permite que qualquer objeto que implemente a interface do assinante(observer) possa se inscrever para notificações de eventos em objetos da publicadora(subject). Você pode adicionar o mecanismo de inscrição em seus botões, permitindo que o cliente coloque seu próprio código através de classes assinantes customizadas.

***
## Problema
Imagine que você tem dois tipos de objetos: uma agência de notícias e uma estação meteorológica. A agência sempre está interessada em saber/informar a temperatura da cidade.

A agência, pode verificar a todo momento com a estação meteorológica se houve alteração na temperatura. Mas nem sempre a temperatura muda e essa checagem seria em vão.
 
Por outro lado, a estação meteorológica poderia mandar milhares de emails para todas as agências cada vez que houvesse uma alteração na temperatura. Isso salvaria algumas agências de incontáveis requisições. Porém, ao mesmo tempo, irritaria outras agências que não estão interessadas em saber a temperatura.
Parece que temos um conflito. Ou a agência gasta tempo verificando se houve alteração na temperatura ou a estação meteorológica gasta recursos notificando as agências  erradas.

***
## Solução/ Exemplo
O objeto que tem um estado interessante é quase sempre chamado de sujeito. Todos os outros objetos que querem saber das mudanças do estado do sujeito são chamados de assinantes(Observer).

O padrão Observer sugere que você adicione um mecanismo de assinatura para a classe publicadora para que objetos individuais possam assinar ou desassinar uma corrente de eventos vindo daquela publicadora. Os observadores devem conhecer o objeto de interesse utilizando a mesma interface.

Assim, todas as agências que desejam saber a temperatura da cidade, pedem para que a estação meteorológica às informe dessas mudanças.

![image](https://user-images.githubusercontent.com/47763472/167303260-d5074f13-6300-474f-977e-8586c1cb844c.png)



Agora, sempre que um evento importante acontece com a subject, ele passa para seus assinantes(observers) e chama um método específico de notificação em seus objetos.
O objeto de interesse (sujeito) deve notificar os observadores quando for atualizado.

Assim, quando houver alguma mudança na temperatura da cidade, a estação meteorológica ira informar a mudança para todas as agencias que assinaram(observers)
![image](https://user-images.githubusercontent.com/47763472/167303293-ba8399d3-0370-4873-8b59-f6b1cc59f713.png)


 
##### Prós 
<ul>
 <li>Princípio aberto/fechado. Você pode introduzir novas classes assinantes sem ter que mudar o código da publicadora (e vice versa se existe uma interface publicadora).</li>
 <li>Você pode estabelecer relações entre objetos durante a execução.</li>
 </ul>
 
##### Contras
<ul>
<li>Assinantes são notificados em ordem aleatória</li>
 </ul>





 




 ###### Referências
 <ul>
   <li>https://refactoring.guru/pt-br/design-patterns/observer<br> </li>
   <li>https://www.devmedia.com.br/design-patterns-observer/16875<br></li>
   <li>Marcos Brizeno - Observer url: https://brizeno.wordpress.com/category/padroes-de-projeto/observer/<br></li>
  </ul>




