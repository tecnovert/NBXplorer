using NBitcoin;
using System;
using System.Collections.Generic;
using System.Text;

namespace NBXplorer
{
	public partial class NBXplorerNetworkProvider
	{
		private void InitParticl(ChainName networkType)
		{
			Add(new NBXplorerNetwork(NBitcoin.Altcoins.Particl.Instance, networkType)
			{
				MinRPCVersion = 190219,
				CoinType = networkType == ChainName.Mainnet ? new KeyPath("44'") : new KeyPath("1'"),
			});
		}

		public NBXplorerNetwork GetPART()
		{
			return GetFromCryptoCode(NBitcoin.Altcoins.Particl.Instance.CryptoCode);
		}
	}
}
