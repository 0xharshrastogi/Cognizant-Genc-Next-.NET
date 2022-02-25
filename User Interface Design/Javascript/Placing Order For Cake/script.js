function OrderCake(orderString) {
  const weight = parseInt(orderString.slice(0, 4)) / 1000;
  const flavour = orderString.slice(4, orderString.length - 3);
  const orderID = parseInt(orderString.slice(orderString.length - 3));
  const cost = Math.round(450 * weight);

  return `Your order for ${Math.round(weight)} kg ${flavour} cake has been taken. You are requested to pay Rs. ${cost} on the order no ${orderID}`;
}
