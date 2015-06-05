module Order

type OrderSide =
    Buy | Sell

type OrderType =
    Limit | Market

type Order(Security : string, Side : OrderSide, Type : OrderType, Qty : int, LimitPrice : decimal, CounterpartyName : string)   =
    let security = Security
    let side = Side
    let orderType = Type
    let quantity = Qty
    let limitPrice = LimitPrice
    let counterPartyName = CounterpartyName 