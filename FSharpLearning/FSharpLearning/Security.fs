module Security
open Order

type AskBook(orders : List<Order>)=
    member this.Orders = orders
    member this.Add (order: Order) : AskBook =
    member this.Process(order: Order) : (Some<Order>, AskBook) =
type BidBook(orders : List<Order>) =
    member this.Orders = orders
    member this.Add (order : Order) : BidBook =
    member this.Process(order : Order) : (Some<Order>), BidBook) =

type Security =
    