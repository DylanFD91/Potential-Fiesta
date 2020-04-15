function getAllHitters(){
  $(document).ready(function() {
      $.ajax({
      	type: 'GET',
        url: "http://localhost:57379/api/baseballstats",
        dataType: 'json',
        success: function(){
          $('.playerData').html('');
        }
      })
      .then(function(data) {
        $.each(data, function(index, value){
  	    	$('.playerData').append(
            "<tr>" +
              "<td>" + value.FirstName + "</td>" +
              "<td>" + value.LastName + "</td>" +
              "<td>" + value.Position + "</td>" +
              "<td>" + value.AtBats + "</td>" +
              "<td>" + value.Runs + "</td>" +
              "<td>" + value.HomeRuns + "</td>" +
              "<td>" + value.RunsBattedIn + "</td>" +
              "<td>" + value.BattingAverage + "</td>" +
            "</tr>"
          );
      	});
      });
    });
}

function getThisHitter(id){
  $(document).ready(function() {
      $.ajax({
      	type: 'GET',
        url: "http://localhost:57379/api/baseballstats/" + id,
        dataType: 'json'
      }).then(function(data) {
        console.log(data);
      	});
      });
}

function createHitter(){
  var data = getHitterObject();
  $(document).ready(function() {
      $.ajax({
        type: 'POST',
        url: "http://localhost:57379/api/baseballstats",
        dataType: 'json',
        data:data
      }).then(function(){
        getAllHitters();
      });
    });
}

function getHitterObject(){
  var data = {
    "FirstName": document.getElementById('firstName').value,
    "LastName": document.getElementById('lastName').value,
    "Position": document.getElementById('position').value,
    "AtBats": document.getElementById('atBats').value,
    "Runs": document.getElementById('runs').value,
    "HomeRuns": document.getElementById('homeRuns').value,
    "RunsBattedIn": document.getElementById('rbi').value,
    "BattingAverage": document.getElementById('battingAverage').value,
  };
  return data;
}

getAllHitters();
