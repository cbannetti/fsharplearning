
open System.IO



//////////////////////////////
//  Order Type Work

type OrderSide =
    Buy | Sell

type OrderType =
    Limit | Market

type Order(Security : string, Side : OrderSide, Type : OrderType, Qty : int, LimitPrice : decimal, CounterPartyName : string)   =
    
    member this.security = Security
    member this.side = Side
    member this.orderType = Type
    member this.quantity = Qty
    member this.limitPrice = LimitPrice
    member this.counterPartyName = CounterPartyName 
    new() = new Order()



//  Reading in lines for Order Type 
let readLines (filePath:string) = seq {
    use sr = new StreamReader (filePath)
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}
let temp = readLines(@"C:\Users\Jared\Documents\GitHub\fsharplearning\FSharpLearning\FSharpLearning\Input.txt")
let first = Seq.nth 0 temp
//////////////////////////////
//  OrderBook Type Work
type OrderBook =
    member this.book = [] : Order list
    member this.processOrder(inputOrder : Order) = 
        0
    



let (askbook : Order list) = []


let myorder : Order = Order("GOOG", Buy, Limit, 500, 50.02M, "Jared")

let buyprocess order askbook = 
    let rec loop = function
        | [] -> //order not filled
        | head::tail when head.limitprice > order.limitprice -> //order not filled
        | head::tail when head.limitprice > order.limitprice -> //order gets filled
    loop askbook
    









