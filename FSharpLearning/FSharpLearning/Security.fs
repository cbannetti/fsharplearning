module Security
open Order


type AskBook(orders : List<Order>)=
    member this.Orders = orders
type BidBook(orders : List<Order>) =
    member this.Orders = orders
 
let askAdd (order: Order) : AskBook =
let askProcess(order: Order) : (Some<Order>, AskBook) =
let bidAdd (order : Order) : BidBook =
let bidProcess(order : Order) : (Some<Order>), BidBook) =

type Security =