//Constructor Function to build a receipt and define the selections as properties.
class OrderReceipt{
    constructor() {
        this.sizeSelection = document.querySelector('input[name=pizzaSizeSelection]:checked').value;
        this.cheeseSelection = document.querySelector('input[name=cheeseSelection]:checked').value;
        this.sauceSelection = document.querySelector('input[name=sauceSelection]:checked').value;
        this.crustSelection = document.querySelector('input[name=crustSelection]:checked').value;
        this.meatSelection = getMeats();
        this.veggiesSelection = getVeggies();
        this.sauceSubTotal = 0
    }
    //get functions for the price properties
    get sizeSubtotal() {
        if (this.sizeSelection === 'personal') {
            return (6);
        } else if (this.sizeSelection === 'medium') {
            return (10);
        } else if (this.sizeSelection === 'large') {
            return (14);
        } else if (this.sizeSelection === 'xtraLarge') {
            return (16);
        } else {
            alert('Invalid pizza size!')
        }
    }
    get meatSubTotal() {
        if (this.meatSelection.length > 1) {
            return (this.meatSelection.length - 1);
        } else {
            return (0);
        }
    }
    get veggiesSubTotal() {
        if (this.veggiesSelection.length > 1) {
            return (this.veggiesSelection.length - 1);
        } else {
            return (0);
        }
    }
    get cheeseSubTotal() {
        if (this.cheeseSelection === 'extraCheese') {
            return (3);
        } else {
            return (0);
        }
    }
    get crustSubTotal() {
        if (this.crustSelection === 'cheeseStuffedCrust') {
            return (3);
        } else {
            return (0);
        }
    }
    get pizzaTotal() {
        return (this.sizeSubtotal + this.meatSubTotal + this.veggiesSubTotal + this.cheeseSubTotal + this.sauceSubTotal + this.crustSubTotal)
    }
}

//Helper Functions to retrieve all the selected meats and veggies
function getMeats() {
    meatList = []
    for (meat of document.querySelectorAll('div[id=collapseMeat] input:checked')) {
        meatList.push(meat.value);
    }
    return (meatList);
}

function getVeggies() {
    veggiesList = []
    for (veggie of document.querySelectorAll('div[id=collapseVeggies] input:checked')) {
        veggiesList.push(veggie.value);
    }
    return (veggiesList);
}

//Reset function to set all choices back to their initial checked state.
function formReset() {
    for (menuElement of document.getElementsByTagName("input")) {
        menuElement.checked = menuElement.defaultChecked;
    }
}

//Function to display the receipt for the currently selected pizza options.
function displayReceipt() {
    currentReceipt = new OrderReceipt;
    document.getElementById('sizeSelection').innerHTML = currentReceipt.sizeSelection;
    document.getElementById('sizeSubTotal').innerHTML = currentReceipt.sizeSubtotal.toFixed(2);
    document.getElementById('meatSelection').innerHTML = currentReceipt.meatSelection.join(", ");
    document.getElementById('meatSubTotal').innerHTML = currentReceipt.meatSubTotal.toFixed(2);
    document.getElementById('veggiesSelection').innerHTML = currentReceipt.veggiesSelection.join(", ");
    document.getElementById('veggiesSubTotal').innerHTML = currentReceipt.veggiesSubTotal.toFixed(2);
    document.getElementById('cheeseSelection').innerHTML = currentReceipt.cheeseSelection;
    document.getElementById('cheeseSubTotal').innerHTML = currentReceipt.cheeseSubTotal.toFixed(2);
    document.getElementById('sauceSelection').innerHTML = currentReceipt.sauceSelection;
    document.getElementById('sauceSubTotal').innerHTML = currentReceipt.sauceSubTotal.toFixed(2);
    document.getElementById('crustSelection').innerHTML = currentReceipt.crustSelection;
    document.getElementById('crustSubTotal').innerHTML = currentReceipt.crustSubTotal.toFixed(2);
    document.getElementById('pizzaTotal').innerHTML = currentReceipt.pizzaTotal.toFixed(2);
    $('#receiptModal').modal(); //JQuery call to display the receipt modal
}
