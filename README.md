# 🃏 C# WinForms 五張撲克牌遊戲 (5-Card Draw Poker)

[![C#](https://img.shields.io/badge/C%23-WinForms-blue.svg)](https://learn.microsoft.com/zh-tw/dotnet/desktop/winforms/)
[![Course](https://img.shields.io/badge/Course-視窗程式設計(II)-green.svg)]()

本專案為「視窗程式設計 (II)」的課程實作專案。透過 C# Windows Forms 開發，結合動態圖片資源管理、陣列演算法與事件驅動，打造出一個完整的五張撲克牌（5-Card Draw）與下注系統遊戲。

🔗 **專案原始碼連結：** [Image_poker GitHub Repository](https://github.com/haoenchu/Image_poker/tree/master)

---

## 🎯 專案目標 (Course Objectives)

根據課程要求，本專案實作了以下核心技術：
1. **專案圖片資源管理：** 將 52 張撲克牌與牌背圖片匯入資源檔，透過字串與亂數動態取得（`ResourceManager.GetObject`）。
2. **動態控制項生成：** 遊戲啟動時動態生成 5 個 `PictureBox` 陣列，並排版至牌桌上。
3. **洗牌與發牌演算法：** 使用 `Random` 進行陣列洗牌（Shuffle），並加入非同步延遲 (`await Task.Delay`) 呈現發牌動畫效果。
4. **牌型邏輯判斷：** 統計算出花色（Color）與點數（Point），運用 `Array.Sort` 與陣列反轉技術，精準判斷包含「皇家同花順」到「一對」等 9 種牌型。
5. **鍵盤事件攔截 (KeyPreview)：** 實作隱藏的開發者測試密技。

---

## 🎮 遊戲功能與特色 (Features)

除基本要求外，本專案額外擴充了完整的**資金與下注系統**，提升遊戲可玩性：

- **💰 資金管理：** 玩家可自訂初始本金，系統會自動防呆（限制正整數、自動捨去零頭  圖二-->圖三 ）並即時顯示目前餘額。
<p float="left">
  <img width="30%" height="138" alt="螢幕擷取畫面 2026-05-03 175134" src="https://github.com/user-attachments/assets/711b3eeb-0a7f-404e-aec3-926d95edde87" />
  <img width="30%" height="138" alt="螢幕擷取畫面 2026-05-03 175456" src="https://github.com/user-attachments/assets/fd968015-f170-45a0-971c-581f423f832a" />
  <img width="30%" height="138" alt="螢幕擷取畫面 2026-05-03 175000" src="https://github.com/user-attachments/assets/91acb0c0-c9d0-43ca-8c86-1be8784feefa" />
</p>

- **🎰 下注與預測：** 玩家可調整下注金額，並透過下拉選單（ComboBox）預測即將開出的牌型，UI 會給予即時的互動反饋與提示。
<img width="617" height="139" alt="image" src="https://github.com/user-attachments/assets/ead1f2f5-f517-48a2-b3ed-6ca1dc4609c6" />

- **🃏 換牌機制：** 發牌後，玩家可點擊不要的撲克牌（牌面會蓋上），點擊「換牌」後系統會從牌堆補上新牌，考驗玩家運氣與策略。
<p float="left">
  <img width="40%" height="199" alt="螢幕擷取畫面 2026-05-03 180415" src="https://github.com/user-attachments/assets/76c6b1c3-2ee0-4af3-a860-08b66c7321d5" />
  <img width="40%" height="188" alt="螢幕擷取畫面 2026-05-03 180420" src="https://github.com/user-attachments/assets/dd35ab27-c565-4294-810c-e62540848f19" />
</p>
- **🏆 結算系統：** 開牌後自動比對「預測牌型」與「實際牌型」，根據不同牌型給予對應的賠率獎金，若破產則會觸發遊戲結束提示。
<p float="left">
<img width="40%" height="500" alt="image" src="https://github.com/user-attachments/assets/0c9312ec-1443-46ce-ae5a-3132a26c9eea" />
<img width="40%" height="500" alt="image" src="https://github.com/user-attachments/assets/642754d3-2405-45dd-b184-96c3d01ddb75" />
</p>

---

## 🕹️ 如何遊玩 (How to Play)

1. **設定資金：** 於左下角輸入你的初始本金，點擊「確認總資金」。
2. **決定下注：** 設定本次下注金額，並選擇你預測會開出的牌型（例如：同花、葫蘆）。
3. **發牌：** 點擊「發牌」，系統會發出 5 張初始牌。
4. **換牌 (Option)：** 點擊畫面上你想要換掉的牌（可複選），接著點擊「換牌」。
5. **判斷牌型：** 點擊「判斷牌型」，系統會結算最終結果，並根據你的預測計算獎金或扣除下注金！

---

## ⌨️ 開發者測試密技 (Cheat Codes)

為方便測試牌型邏輯，在表單介面按下以下鍵盤按鍵，可強制發出特定牌型（需在發牌前或等待期間使用）：

* `Q` : ♠️ 皇家同花順 (Royal Flush)
* `W` : ♦️ 同花順 (Straight Flush)
* `E` : ♥️ 同花 (Flush)
* `R` : 鐵支 / 四條 (Four of a Kind)
* `T` : 葫蘆 (Full House)
* `Y` : 三條 (Three of a Kind)

*(註：要在按下換牌btn前才能觸發)*

---

## 🛠️ 開發環境 (Environment)
* IDE: Visual Studio
* 語言: C#
* 框架: .NET Framework (Windows Forms)
