function ebBill(unitsConsumed) {
  if (unitsConsumed < 100) return 0;

  unitsConsumed -= 100;

  if (unitsConsumed > 100 && unitsConsumed <= 300) return unitsConsumed * 1.5;
  if (unitsConsumed > 300 && unitsConsumed <= 600) return unitsConsumed * 3.5;
  if (unitsConsumed > 600 && unitsConsumed <= 1000) return unitsConsumed * 5.5;
  return 1000 * 7.5;
}
