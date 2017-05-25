﻿using ArtLee.WechatPay.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtLee.WechatPay.Request
{
    public class CloseOrderRequest : IWechatPayRequest<CloseOrderResponse>
    {
        #region 构造函数

        public CloseOrderRequest()
        {
        }

        #endregion

        #region 属性

        public string ApiUrl
        {
            get { return "https://api.mch.weixin.qq.com/pay/closeorder"; }
        }

        public bool NeedCert
        {
            get { return false; }
        }

        /// <summary>
        /// 商户订单号	
        /// </summary>
        public string OutTradeNo { get; set; }

        #endregion

        #region 公共方法

        public IDictionary<string, string> GetParameters()
        {
            var parameteers = new Dictionary<string, string>();
            parameteers.Add("out_trade_no", OutTradeNo);
            return parameteers;
        }

        #endregion
    }
}
