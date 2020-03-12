<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8">
        <title>All schools in a swedish municpality</title>
        <link rel="stylesheet" href="css/style.css">
        <link rel="icon" href="favicon.ico">
        <!-- <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"> -->
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

     
    </head>
    <body>
        <div>
            <header>
                <nav class="navvv">
                    <a href="me.html">Me</a> |
                    <a href="report.html">Report</a> | 
                    <a href="about.html">About</a> |
                    <a href="schools.html">Schools</a>
                </nav class="navvv">
            </header>
        </div>
        

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
       

        <div id="duck" class="duck"></div>
       
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


   
    
