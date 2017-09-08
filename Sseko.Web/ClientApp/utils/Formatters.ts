export const Formatters = {
    moneyRounded: (amount) => (
        "$" + amount.toFixed(0).replace(/(\d)(?=(\d{3})+$)/g, "$1,")
    ),

    moneyDecimal: (amount) => (
        "$" + amount.toFixed(2).replace(/(\d)(?=(\d{3})+\.)/g, "$1,")
    )
}