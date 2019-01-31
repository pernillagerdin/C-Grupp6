$(document).ready(() => {
    console.log("meetings.js loaded successfully.")
});


$("body").on("click", "#proposeMeetingBtn", toggleProposalForm)
$("body").on("click", "#cancelProposalBtn", toggleProposalForm)

$("#personSearch").on("keyup", searchPeople);

function toggleProposalForm() {
    $("#newMeetingDiv").toggleClass("d-none");
    $("#proposeMeetingBtn").toggleClass("d-none");
}

var listOfPeople = function () {
    $.ajax({
        type: "GET",
        url: "/api/MeetingApi/",
        success: function (data) {
            var listOfVisitors = "";
            $.each(data, function (i, item) {

            });
        },
        error: function (xhr, status, error) {
            var err = JSON.parse(xhr.responseText);
            console.log(err.Message);
            console.log("Error: Unable to load latest visitors.");
        }
    });
}

function searchPeople() {
    var searchString = $("#SearchField").val();

    
}