using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.rushikesh2k04.AlgoArena.AlgoArenaReward_5d297e73
{


    //
    // 
    //    ARC-4 Contract for distributing Algo and NFT rewards to AlgoArena users.
    //    The contract owner (game server) is the only entity authorized to call 
    //    the reward_user method, which executes two Inner Transactions atomically:
    //    1. An Algo payment to the winner.
    //    2. An Asset Transfer (NFT) to the winner.
    //    
    //
    public class AlgoArenaRewardProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AlgoArenaRewardProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///Sets the contract owner to the sender on application creation.
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Distributes Algos and an NFT to a recipient.
        ///</summary>
        /// <param name="recipient_address"> </param>
        /// <param name="algo_reward_amount"> </param>
        /// <param name="nft_asset_id"> </param>
        public async Task RewardUser(Algorand.Address recipient_address, ulong algo_reward_amount, ulong nft_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 41, 110, 226 };
            var recipient_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipient_addressAbi.From(recipient_address);
            var algo_reward_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); algo_reward_amountAbi.From(algo_reward_amount);
            var nft_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nft_asset_idAbi.From(nft_asset_id);

            var result = await base.CallApp(new List<object> { abiHandle, recipient_addressAbi, algo_reward_amountAbi, nft_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> RewardUser_Transactions(Algorand.Address recipient_address, ulong algo_reward_amount, ulong nft_asset_id, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 106, 41, 110, 226 };
            var recipient_addressAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); recipient_addressAbi.From(recipient_address);
            var algo_reward_amountAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); algo_reward_amountAbi.From(algo_reward_amount);
            var nft_asset_idAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); nft_asset_idAbi.From(nft_asset_id);

            return await base.MakeTransactionList(new List<object> { abiHandle, recipient_addressAbi, algo_reward_amountAbi, nft_asset_idAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWxnb0FyZW5hUmV3YXJkIiwiZGVzYyI6IlxuICAgIEFSQy00IENvbnRyYWN0IGZvciBkaXN0cmlidXRpbmcgQWxnbyBhbmQgTkZUIHJld2FyZHMgdG8gQWxnb0FyZW5hIHVzZXJzLlxuICAgIFRoZSBjb250cmFjdCBvd25lciAoZ2FtZSBzZXJ2ZXIpIGlzIHRoZSBvbmx5IGVudGl0eSBhdXRob3JpemVkIHRvIGNhbGwgXG4gICAgdGhlIHJld2FyZF91c2VyIG1ldGhvZCwgd2hpY2ggZXhlY3V0ZXMgdHdvIElubmVyIFRyYW5zYWN0aW9ucyBhdG9taWNhbGx5OlxuICAgIDEuIEFuIEFsZ28gcGF5bWVudCB0byB0aGUgd2lubmVyLlxuICAgIDIuIEFuIEFzc2V0IFRyYW5zZmVyIChORlQpIHRvIHRoZSB3aW5uZXIuXG4gICAgIiwibmV0d29ya3MiOnt9LCJzdHJ1Y3RzIjp7fSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJTZXRzIHRoZSBjb250cmFjdCBvd25lciB0byB0aGUgc2VuZGVyIG9uIGFwcGxpY2F0aW9uIGNyZWF0aW9uLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyZXdhcmRfdXNlciIsImRlc2MiOiJEaXN0cmlidXRlcyBBbGdvcyBhbmQgYW4gTkZUIHRvIGEgcmVjaXBpZW50LiIsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoicmVjaXBpZW50X2FkZHJlc3MiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImFsZ29fcmV3YXJkX2Ftb3VudCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibmZ0X2Fzc2V0X2lkIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMzZdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBOb09wICYmIGNhbiBvbmx5IGNhbGwgd2hlbiBjcmVhdGluZyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzExMF0sImVycm9yTWVzc2FnZSI6Ik9ubHkgdGhlIEFsZ29BcmVuYSBvd25lci9zZXJ2ZXIgY2FuIGlzc3VlIHJld2FyZHMuIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTA2XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5vd25lciBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls4Nl0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnN0YXRpY19hcnJheTxhcmM0LnVpbnQ4LCAzMj4iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5NCwxMDJdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC51aW50NjQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURBZ09Bb2dJQ0FnWW5sMFpXTmliRzlqYXlBaWIzZHVaWEpmWVdSa2NpSUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgyRnlaVzVoTDJOdmJuUnlZV04wTG5CNU9qRTFDaUFnSUNBdkx5QnpaV3htTG05M2JtVnlJRDBnUjJ4dlltRnNVM1JoZEdVb1FXUmtjbVZ6Y3lncExDQnJaWGs5SW05M2JtVnlYMkZrWkhJaUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWIzZHVaWEpmWVdSa2NpSUtJQ0FnSUdkc2IySmhiQ0JhWlhKdlFXUmtjbVZ6Y3dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmWVhKbGJtRXZZMjl1ZEhKaFkzUXVjSGs2TlFvZ0lDQWdMeThnWTJ4aGMzTWdRV3huYjBGeVpXNWhVbVYzWVhKa0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzRnVG5WdFFYQndRWEpuY3dvZ0lDQWdZbm9nYldGcGJsOWZYMkZzWjI5d2VWOWtaV1poZFd4MFgyTnlaV0YwWlVBeE1Rb2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUUtJQ0FnSUhCMWMyaGllWFJsYzNNZ01IZzBZelZqTmpGaVlTQXdlRFpoTWprMlpXVXlJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSnlaWGRoY21SZmRYTmxjaWhoWkdSeVpYTnpMSFZwYm5RMk5DeDFhVzUwTmpRcGRtOXBaQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUdOeVpXRjBaU0J5WlhkaGNtUmZkWE5sY2dvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERXhPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFnTHk4Z1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0NBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11WVd4bmIxOWhjbVZ1WVM1amIyNTBjbUZqZEM1QmJHZHZRWEpsYm1GU1pYZGhjbVF1WTNKbFlYUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWTNKbFlYUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmWVhKbGJtRXZZMjl1ZEhKaFkzUXVjSGs2TWpBS0lDQWdJQzh2SUhObGJHWXViM2R1WlhJdWRtRnNkV1VnUFNCQlpHUnlaWE56S0ZSNGJpNXpaVzVrWlhJcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKdmQyNWxjbDloWkdSeUlnb2dJQ0FnZEhodUlGTmxibVJsY2dvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgyRnlaVzVoTDJOdmJuUnlZV04wTG5CNU9qRTNDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdVlXeG5iMTloY21WdVlTNWpiMjUwY21GamRDNUJiR2R2UVhKbGJtRlNaWGRoY21RdWNtVjNZWEprWDNWelpYSmJjbTkxZEdsdVoxMG9LU0F0UGlCMmIybGtPZ3B5WlhkaGNtUmZkWE5sY2pvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgyRnlaVzVoTDJOdmJuUnlZV04wTG5CNU9qSXlDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLQ2tLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCd2RYTm9hVzUwSURNeUlDOHZJRE15Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklHbHVkbUZzYVdRZ2JuVnRZbVZ5SUc5bUlHSjVkR1Z6SUdadmNpQmhjbU0wTG5OMFlYUnBZMTloY25KaGVUeGhjbU0wTG5WcGJuUTRMQ0F6TWo0S0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURJS0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpJZ0x5OGdPQW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCcGJuWmhiR2xrSUc1MWJXSmxjaUJ2WmlCaWVYUmxjeUJtYjNJZ1lYSmpOQzUxYVc1ME5qUUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklETUtJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwYm5Salh6SWdMeThnT0FvZ0lDQWdQVDBLSUNBZ0lHRnpjMlZ5ZENBdkx5QnBiblpoYkdsa0lHNTFiV0psY2lCdlppQmllWFJsY3lCbWIzSWdZWEpqTkM1MWFXNTBOalFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDJGeVpXNWhMMk52Ym5SeVlXTjBMbkI1T2pNd0NpQWdJQ0F2THlCaGMzTmxjblFnVkhodUxuTmxibVJsY2lBOVBTQnpaV3htTG05M2JtVnlMblpoYkhWbExDQWlUMjVzZVNCMGFHVWdRV3huYjBGeVpXNWhJRzkzYm1WeUwzTmxjblpsY2lCallXNGdhWE56ZFdVZ2NtVjNZWEprY3k0aUNpQWdJQ0JwYm5Salh6RWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpYjNkdVpYSmZZV1JrY2lJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmWjJWMFgyVjRDaUFnSUNCaGMzTmxjblFnTHk4Z1kyaGxZMnNnYzJWc1ppNXZkMjVsY2lCbGVHbHpkSE1LSUNBZ0lIUjRiaUJUWlc1a1pYSUtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1c2VTQjBhR1VnUVd4bmIwRnlaVzVoSUc5M2JtVnlMM05sY25abGNpQmpZVzRnYVhOemRXVWdjbVYzWVhKa2N5NEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYMkZ5Wlc1aEwyTnZiblJ5WVdOMExuQjVPak15TFRNMkNpQWdJQ0F2THlCcGRIaHVMbEJoZVcxbGJuUW9DaUFnSUNBdkx5QWdJQ0FnYzJWdVpHVnlQVWRzYjJKaGJDNWpkWEp5Wlc1MFgyRndjR3hwWTJGMGFXOXVYMkZrWkhKbGMzTXNDaUFnSUNBdkx5QWdJQ0FnY21WalpXbDJaWEk5Y21WamFYQnBaVzUwWDJGa1pISmxjM011Ym1GMGFYWmxMQW9nSUNBZ0x5OGdJQ0FnSUdGdGIzVnVkRDFoYkdkdlgzSmxkMkZ5WkY5aGJXOTFiblF1Ym1GMGFYWmxDaUFnSUNBdkx5QXBMbk4xWW0xcGRDZ3BDaUFnSUNCcGRIaHVYMkpsWjJsdUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOWhjbVZ1WVM5amIyNTBjbUZqZEM1d2VUb3pNd29nSUNBZ0x5OGdjMlZ1WkdWeVBVZHNiMkpoYkM1amRYSnlaVzUwWDJGd2NHeHBZMkYwYVc5dVgyRmtaSEpsYzNNc0NpQWdJQ0JuYkc5aVlXd2dRM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWZZWEpsYm1FdlkyOXVkSEpoWTNRdWNIazZNelVLSUNBZ0lDOHZJR0Z0YjNWdWREMWhiR2R2WDNKbGQyRnlaRjloYlc5MWJuUXVibUYwYVhabENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lHSjBiMmtLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JrYVdjZ01nb2dJQ0FnYVhSNGJsOW1hV1ZzWkNCU1pXTmxhWFpsY2dvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZYMkZ5Wlc1aEwyTnZiblJ5WVdOMExuQjVPak15Q2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb0NpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ2FYUjRibDltYVdWc1pDQkdaV1VLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDJGeVpXNWhMMk52Ym5SeVlXTjBMbkI1T2pNeUxUTTJDaUFnSUNBdkx5QnBkSGh1TGxCaGVXMWxiblFvQ2lBZ0lDQXZMeUFnSUNBZ2MyVnVaR1Z5UFVkc2IySmhiQzVqZFhKeVpXNTBYMkZ3Y0d4cFkyRjBhVzl1WDJGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVmpaV2wyWlhJOWNtVmphWEJwWlc1MFgyRmtaSEpsYzNNdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnRiM1Z1ZEQxaGJHZHZYM0psZDJGeVpGOWhiVzkxYm5RdWJtRjBhWFpsQ2lBZ0lDQXZMeUFwTG5OMVltMXBkQ2dwQ2lBZ0lDQnBkSGh1WDNOMVltMXBkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmWVhKbGJtRXZZMjl1ZEhKaFkzUXVjSGs2TXpndE5ETUtJQ0FnSUM4dklHbDBlRzR1UVhOelpYUlVjbUZ1YzJabGNpZ0tJQ0FnSUM4dklDQWdJQ0J6Wlc1a1pYSTlSMnh2WW1Gc0xtTjFjbkpsYm5SZllYQndiR2xqWVhScGIyNWZZV1JrY21WemN5d0tJQ0FnSUM4dklDQWdJQ0JoYzNObGRGOXlaV05sYVhabGNqMXlaV05wY0dsbGJuUmZZV1JrY21WemN5NXVZWFJwZG1Vc0NpQWdJQ0F2THlBZ0lDQWdlR1psY2w5aGMzTmxkRDF1Wm5SZllYTnpaWFJmYVdRdWJtRjBhWFpsTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDJGdGIzVnVkRDFPWVhScGRtVlZTVzUwTmpRb01Ta0tJQ0FnSUM4dklDa3VjM1ZpYldsMEtDa0tJQ0FnSUdsMGVHNWZZbVZuYVc0S0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlgyRnlaVzVoTDJOdmJuUnlZV04wTG5CNU9qTTVDaUFnSUNBdkx5QnpaVzVrWlhJOVIyeHZZbUZzTG1OMWNuSmxiblJmWVhCd2JHbGpZWFJwYjI1ZllXUmtjbVZ6Y3l3S0lDQWdJR2RzYjJKaGJDQkRkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOWhjbVZ1WVM5amIyNTBjbUZqZEM1d2VUbzBNUW9nSUNBZ0x5OGdlR1psY2w5aGMzTmxkRDF1Wm5SZllYTnpaWFJmYVdRdWJtRjBhWFpsTEFvZ0lDQWdjM2RoY0FvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5ZllYSmxibUV2WTI5dWRISmhZM1F1Y0hrNk5ESUtJQ0FnSUM4dklHRnpjMlYwWDJGdGIzVnVkRDFPWVhScGRtVlZTVzUwTmpRb01Ta0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVGemMyVjBRVzF2ZFc1MENpQWdJQ0JwZEhodVgyWnBaV3hrSUZobVpYSkJjM05sZEFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JUWlc1a1pYSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1FYTnpaWFJTWldObGFYWmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlmWVhKbGJtRXZZMjl1ZEhKaFkzUXVjSGs2TXpnS0lDQWdJQzh2SUdsMGVHNHVRWE56WlhSVWNtRnVjMlpsY2lnS0lDQWdJSEIxYzJocGJuUWdOQ0F2THlCaGVHWmxjZ29nSUNBZ2FYUjRibDltYVdWc1pDQlVlWEJsUlc1MWJRb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR2wwZUc1ZlptbGxiR1FnUm1WbENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIxOWhjbVZ1WVM5amIyNTBjbUZqZEM1d2VUb3pPQzAwTXdvZ0lDQWdMeThnYVhSNGJpNUJjM05sZEZSeVlXNXpabVZ5S0FvZ0lDQWdMeThnSUNBZ0lITmxibVJsY2oxSGJHOWlZV3d1WTNWeWNtVnVkRjloY0hCc2FXTmhkR2x2Ymw5aFpHUnlaWE56TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwWDNKbFkyVnBkbVZ5UFhKbFkybHdhV1Z1ZEY5aFpHUnlaWE56TG01aGRHbDJaU3dLSUNBZ0lDOHZJQ0FnSUNCNFptVnlYMkZ6YzJWMFBXNW1kRjloYzNObGRGOXBaQzV1WVhScGRtVXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUmZZVzF2ZFc1MFBVNWhkR2wyWlZWSmJuUTJOQ2d4S1FvZ0lDQWdMeThnS1M1emRXSnRhWFFvS1FvZ0lDQWdhWFI0Ymw5emRXSnRhWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WDJGeVpXNWhMMk52Ym5SeVlXTjBMbkI1T2pJeUNpQWdJQ0F2THlCQVlXSnBiV1YwYUc5a0tDa0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLIn0sImJ5dGVDb2RlIjp7ImFwcHJvdmFsIjoiQ3lBREFRQUlKZ0VLYjNkdVpYSmZZV1JrY2pFWVFBQUVLRElEWnpFYlFRQWRNUmtVUkRFWVJJSUNCRXhjWWJvRWFpbHU0allhQUk0Q0FBc0FFUUF4R1JReEdCUVFSQ0pES0RFQVp5SkROaG9CU1JXQklCSkVOaG9DU1JVa0VrUTJHZ05KRlNRU1JDTW9aVVF4QUJKRXNUSUtUd0lYc2doTEFySUhzZ0Fpc2hBanNnR3pzVElLVEJjaXNoS3lFYklBc2hTQkJMSVFJN0lCc3lKRCIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjQsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
