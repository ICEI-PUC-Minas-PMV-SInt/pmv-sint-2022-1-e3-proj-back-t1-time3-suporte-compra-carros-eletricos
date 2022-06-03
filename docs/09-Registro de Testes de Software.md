# Registro de Testes de Software

Evidências dos testes de software realizados no sistema pela equipe, baseado em um plano de testes pré-definidos nesta documentação: <a href="08-Plano de Testes de Software.md">Plano de Testes de Software</a>.


<table>
  <tr>
    <th> Caso teste 1 </th>
    <th> CT-01  Cadastro de veículos </th>
  </tr>
  <tr>
  <th> Sequência </th>
   <th> 
     <li>1-Fazer o login para as acessar as opções de cadastro;</li>
     <li>2-Entrar na aba 'Veículos a combustão' e clicar em "Create";</li>
     <li>3-Preencher dados necessários (no vídeo foram colocados dados aleatórios apenas para demostração);</li>
     <li>4-Clicar no botão "Create" no final da tela;</li>
     <li>5-Repetir os passos 2,3 e 4 na aba "Veículos elétricos",</li>
     <li>Verificar se os dados persistiram depois da recarga da tela.</li>
  </th>
    </th>
  </tr>
  <tr>
  <th> Critérios de Êxito</th>
<th>
  <li> Cadastro de veículos elétricos e a combustão feito com sucesso</li>
  <li> Dados continuaram na tela </li>
</th>
  </tr>  
</table>

https://user-images.githubusercontent.com/81269914/171930936-bdf09c81-2497-4b27-b5be-3bf39a3520da.mp4

<table>
  <tr>
    <th> Caso teste 2 </th>
    <th> CT-02 Login e logoff </th>
  </tr>
  <tr>
  <th> Sequência </th>
   <th> 
     <li>  
     Verificação inicial: <br/>
       -  Entrar na aba "Usuários" e verificar que não há nenhum criado;<br/>
       -  Fazer login com um usuário inexistente.
     </li>
     </li>
  <li>  Passos </li>
     <li>1-Entrar na aba "Usuário" e criar um novo perfil;</li>
     <li>2-Fazer Login com dados criados no passo anterior;</li>
     <li>3-Verificar se o nome criado aparece na barra superior, "Hi, Nome";</li>
     <li>4-Clicar no botão Logout</li>
  </th>
  </tr>
  <tr>
  <th> Critérios de Êxito</th>
<th>
  <li> Usuários/adms conseguem fazer login e logoff </li>
</th>
  </tr>  
</table>

https://user-images.githubusercontent.com/81269914/171930104-4c268296-b10e-4870-82d7-4eaf6543552a.mp4

<table>
  <tr>
    <th> Caso teste 3 </th>
    <th> CT-03 Usuários não logados tem acesso restrito </th>
  </tr>
  <tr>
  <th> Sequência </th>
   <th> 
     <li> Todas as opções de cadastro estão aparecendo na barra superior, já que o usuário está logado no sistema mas uma vez que ele faz o logout elas desaparecem e permanece apenas a que é de acesso geral. </li>
  </th>
  </th>
  </tr>
  <tr>
  <th> Critérios de Êxito</th>
<th>
  <li> Usuários/adms não logados não conseguem ver informações que eles não tem acesso </li>
</th>
  </tr>  
</table>

https://user-images.githubusercontent.com/81269914/171930202-e400db48-2ade-4435-86dd-11660bd084c3.mp4

<table>
  <tr>
    <th> Caso teste 4 </th>
    <th> CT-04 Proteção de senhas </th>
  </tr>
  <tr>
  <th> Sequência </th>
   <th> 
     <li> Demostração que todos os usuários, logados ou não, não podem ver as senhas de outros cadastros nem do próprio, em nunhuma das alterações possíveis de se fazer;
     </li>
     <li>No segudo vídeo podemos ver que a senha está sendo armazenada por meio de criptografia.  </li>
  </th>
  </th>
  </tr>
  <tr>
  <th> Critérios de Êxito</th>
<th>
  <li> Provar que as senhas não podem ser vistas a momento nenhum  </li>
   <li> No banco de dados as senhas são armazenadas usando chave criptográfica (hash) </li>
</th>
  </tr>  
</table>

https://user-images.githubusercontent.com/81269914/171933827-27632c8d-8b9b-4291-9073-20371b0f52d2.mp4

https://user-images.githubusercontent.com/81269914/171933880-7741bf21-8c54-4059-a09b-cb818b560ff9.mp4

## Avaliação

Como foi possível observar no tópico anterior,em todos os casos os critérios de êxito foram alcançados com sucesso. 

