//shipping form reset
function reset(){
  document.querySelector('#fNameError').textContent="";
  document.querySelector('#lNameError').textContent="";
  document.querySelector('#uNameError').textContent="";
  document.querySelector('#addressError').textContent="";
  document.querySelector('#countryError').textContent="";
  document.querySelector('#cityError').textContent="";
  document.querySelector('#phoneError').textContent="";
  document.querySelector('#postCodeError').textContent="";
  document.querySelector('#amount').textContent="0";
  document.querySelector('#amount2').textContent="0";
  document.querySelector('#amount3').textContent="0";
  document.querySelector('#cart-subtotal').textContent="0";
  document.querySelector('#cart-tex').textContent="0";
  document.querySelector('#cart-total').textContent="0";
  document.querySelector('#summary').textContent="";
}
//shipping form validation
function validate(e) {

  e.preventDefault();

  var valid = true;
  
  if (shipping.firstName.value === "") {
    
      document.querySelector('#fNameError').textContent = "*Please enter a First Name*";
      valid = false;
  }

  if (shipping.lastName.value === "") {
    document.querySelector('#lNameError').textContent = "*Please enter a Last Name*";
    valid = false;
  }

  if (shipping.useName.value === "") {
    document.querySelector('#uNameError').textContent = "*Please enter a User Name*";
    valid = false;
  }

  if (shipping.adress1.value === "") {
    document.querySelector('#addressError').textContent = "*Please enter a Address*";
    valid = false;
  }

  
  if (shipping.country.options.selectedIndex === 0) {
      valid = false;
      document.querySelector('#countryError').textContent = "*Select Country*";
  }

  if (shipping.city.options.selectedIndex === 0) {
      valid = false;
      document.querySelector('#cityError').textContent = "*Select City*";
  }



  if (shipping.phone.value.length !== 10) {
      valid = false;
      document.querySelector('#phoneError').textContent = "*Please enter a valid 10-digit phone number*";

  }

  if (shipping.postCode.value.length !== 6) {
    valid = false;
    document.querySelector('#postCodeError').textContent = "*Please enter a 6 digits Postcode*";
  }

  if (valid) {
    // get from information
    showInput();
    function showInput() {
      document.querySelector('#sum0').textContent = 'User information: ';
      document.querySelector('#sum1').textContent = 'First Name: ' + document.querySelector("#fName").value;
      document.querySelector('#sum2').textContent = 'Last Name: ' + document.querySelector("#lName").value;
      document.querySelector('#sum3').textContent = 'User Name: ' + document.querySelector("#uName").value;
      document.querySelector('#sum4').textContent = 'Email: ' + document.querySelector("#eMail").value;
      document.querySelector('#sum5').textContent = 'Phone: ' + document.querySelector("#phone").value;
      document.querySelector('#sum6').textContent = 'Address: ' + document.querySelector("#adress").value + ' ' + document.querySelector("#adress2").value
       + ' ' + document.querySelector("#country").value + ' ' + document.querySelector("#city").value;
      document.querySelector('#sum7').textContent = 'Postcode: ' + document.querySelector("#pc").value;
      document.querySelector('#sum8').textContent = 'Shipping Date: ' + document.querySelector("#sdate").value;
      
      document.querySelector('#pic0').textContent = 'You picked the following items: ';
      document.querySelector('#pic1').textContent = document.querySelector("#mocha").value + 'cups Mocha';
      document.querySelector('#pic2').textContent = document.querySelector("#latte").value + 'cups Latte';
      document.querySelector('#pic3').textContent = document.querySelector("#capp").value + 'cups Cappuccino';    
    }
    
  }
  

  return valid;

};


//after input clean the alert message

document.querySelector('#fName').addEventListener("blur", function(){
  if(this.value !== ""){
    fNameError.textContent = "";
  }
});

document.querySelector('#lName').addEventListener("blur", function(){
  if(this.value !== ""){
    lNameError.textContent = "";
  }
});

document.querySelector('#uName').addEventListener("blur", function(){
  if(this.value !== ""){
    uNameError.textContent = "";
  }
});

document.querySelector('#eMail').addEventListener("blur", function(){
  if(this.value !== ""){
    emailError.textContent = "";
  }
});

document.querySelector('#phone').addEventListener("blur", function(){
  if(this.value.length === 10){
    phoneError.textContent = "";
  }
});

document.querySelector('#adress').addEventListener("blur", function(){
  if(this.value !== ""){
    addressError.textContent = "";
  }
});

document.querySelector('#country').addEventListener("click", function(){
  if(shipping.country.options.selectedIndex !== -1){
    countryError.textContent = "";
  }
});

document.querySelector('#city').addEventListener("click", function(){
  if(shipping.city.options.selectedIndex !== -1){
    cityError.textContent = "";
  }
});

document.querySelector('#pc').addEventListener("blur", function(){
  if(this.value.length === 6){
    postCodeError.textContent = "";
  }
});

document.shipping.addEventListener("submit", validate);
document.shipping.addEventListener("reset", reset);

var coffee = [
  {
    "image": "images/mocha.jpeg",
    "productName": "Mocha",
    "qty": 0,
    "price": 7
  },
  {
    "image": "images/latte.jpeg",
    "productName": "Latte",
    "qty": 0,
    "price": 9
  },
  {
    "image": "images/cappuccino.jpeg",
    "productName": "Cappuccino",
    "qty": 0,
    "price": 8
  }
]




// shopping cart main function
$(document).ready(function() {
    update_amounts();
      $('.qty, .product-price').on('keyup keypress blur change',
        function(e){
        update_amounts();
  });
});

function update_amounts(){
  var sum = 0.0;
  var subtotal = 0.0;
  var tex = 0.0;
  $('.myTable >.product').each(function() {
    var qty = $(this).find('.qty').val(); //add quantity value
    var productPrice = $(this).find('.product-price').val(); //add price value
    var amount = qty*productPrice; //calculate cost per product
    $(this).find('.amount').text(''+amount); //show each cost
    subtotal += amount;
    tex += amount*0.13; // calculate total tex 
    sum = subtotal+tex; //sum varies with cost and tex
    
  });
  $('.before-tex').text(subtotal);
  $('.totals-tex').text(tex);
  $('.after-tex').text(sum);
}

//function for quantity increment and decrement
var incrementQty;
var decrementQty;
var plusButton = $(".cart-qty-plus");
var minusButton = $(".cart-qty-minus");

var incrementQty = plusButton.click(function() {
  var $n = $(this).parent(".button-contatiner").find(".qty");
  $n.val(Number($n.val())+1);
  update_amounts();
});

var decrementQty = minusButton.click(function() {
  var $n = $(this).parent(".button-contatiner").find(".qty");
  var qtyVal = Number($n.val());
  if (qtyVal > 0) {
    $n.val(qtyVal-1);
  }
  update_amounts();
});

