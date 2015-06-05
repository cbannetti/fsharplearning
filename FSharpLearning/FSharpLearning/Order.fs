module Order

type OrderSide =
    Buy | Sell

type OrderType =
    Limit | Market

type Order(Security : string, Side : OrderSide, Type : OrderType, Qty : int, LimitPrice : decimal, CounterpartyName : string)   =
    member this.security = Security
    member this.side = Side
    member this.orderType = Type
    member this.quantity = Qty
    member this.limitPrice = LimitPrice
    member this.counterPartyName = CounterpartyName 