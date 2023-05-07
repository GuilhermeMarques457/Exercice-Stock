﻿using StocksApp.ServiceContracts.DTO;

namespace StocksApp.ServiceContracts
{
    public interface IStockService
    {
        BuyOrderResponse CreateBuyOrder(BuyOrderRequest? buyOrderRequest);

        SellOrderResponse CreateSellOrder(SellOrderRequest? sellOrderRequest);

        List<BuyOrderResponse> GetBuyOrders();

        List<SellOrderResponse> GetSellOrders();
    }
}
