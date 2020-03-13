<?php
require __DIR__."/view/header.php";
?>
        

        <h1>Table of Schools</h1>

    
    <button class="buttonDisplay"
    name="Button_schools" onclick="myScript()" >Click to see Schools</button>

    <p id="demo"></p>

    <div>
        <p>
            <table   id="school_table"  border="10px">
                <thead class="thead-light">
                    <tr>
                        <th>SkolenhetsName</th>
                        <th>Skolenhetskod</th>
                        <th>KommunKod</th>
                        <th>PeOrgNr</th>
                    </tr>
                </thead>
                
            </table>
        </p>
       
    </div>
       

       
        <script>
          function myScript(){
   
   $.getJSON("data/1081.json", function(data){
         var school_data = '';
         $.each(data.Skolenheter, function(key, value){
             school_data += '<tr>';
                 school_data += '<td>' + value.Skolenhetsnamn + '</td>';
                 school_data += '<td>' + value.Skolenhetskod + '</td>';
                 school_data += '<td>' + value.Kommunkod + '</td>';
                 school_data += '<td>' + value.PeOrgNr + '</td>';
             school_data += '</tr>';
             });
         $('#school_table').append(school_data);

     });

   };

        </script>
      
        
        <script type="text/javascript" src="js/duck.js" ></script>
        <script  id="myScript" type="text/javascript" src="js/fetch.js" ></script>

    </body>
</html>

<?php
require __DIR__."/view/footer.php";
?>
   
    
