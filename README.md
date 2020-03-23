# Contract Management

A company wants to automate the processing of its contracts. The processing of a contract consists on generating the installments to be paid for that contract, based on the desired number of months.
The company uses an online payment service to pay the installments. Online payment services typically charge a monthly interest, as well as a fee for payment. For the time being, the service hired by the company is Paypal, which applies a simple fee of 1% per loan, plus a fee of 2%.
Make a program for the details of a contract (contract number, contract date, and total contract value). Then, the program should read the number of months for the installment of the contract, and from there generate the records of installments to be paid (date and amount), being the first to be paid in a month after the contract has been signed, the second installment of the months after the contract and the installment.

## Example:

```
Enter contract details 
Contract ID: 8028 
Date (dd/MM/yyyy): 25/06/2018 
Contract value: 600.00 
Enter number of installments: 3 
Installments: 
25/07/2018 - 206.04 
25/08/2018 - 208.08 
25/09/2018 - 210.12
```

Calculations(1% monthly simple interest + 2% payment fee): 

* Quota #1: 
  * 200 + 1% * 1 = 202 
  * 202 + 2% = 206.04 
* Quota #2: 
  * 200 + 1% * 2 = 204 
  * 204 + 2% = 208.08
* Quota #3: 
  * 200 + 1% * 3 = 206 
  * 206 + 2% = 210.12
