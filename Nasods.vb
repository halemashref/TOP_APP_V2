Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Nasods
    Private st1 As String
    Private as1 As Integer
    Private ch1 As Char
    Private st As Char

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Nasos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Clipboard.SetText(TextBox1.Text)
        Halimm.Show()
        Halimm.Label2.Text = "تم نسخ النص بنجاح إلى الحافظة."

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim txt As String = TextBox2.Text
        TextBox3.Visible = False

        TextBox1.Clear()
        txt = txt.Replace("ا", "أ")

        txt = txt.Replace("ي", "يًّ")

        txt = txt.Replace("ك", "ڪـ")

        txt = txt.Replace("ب", "بہ")

        txt = txt.Replace("ا", "أ")

        txt = txt.Replace("ت", "تہ")

        txt = txt.Replace("ث", "ثہ")

        txt = txt.Replace("ج", "جْ")

        txt = txt.Replace("ح", "ב,")

        txt = txt.Replace("خ", "خِہ")

        txt = txt.Replace("س", "ڛً")

        txt = txt.Replace("ش", "ڜ")

        txt = txt.Replace("ص", "صًـٍـًہ")

        txt = txt.Replace("ض", "ضًـٍـًہ")

        txt = txt.Replace("ظ", "ظٍـًہ")

        txt = txt.Replace("ع", "عً")

        txt = txt.Replace("غ", "غً")

        txt = txt.Replace("ض", "ضًـٍـًہ")

        txt = txt.Replace("ل", "ل")

        txt = txt.Replace("م", "مہ")

        txt = txt.Replace("ن", "טּ")

        txt = txt.Replace("ه", "هہـ")

        txt = txt.Replace("و", "وُ")

        txt = txt.Replace("ي", "يًّ")
        txt = txt.Replace("a", "Ǟ")

        txt = txt.Replace("b", "в")

        txt = txt.Replace("c", "ƈƈƈ")

        txt = txt.Replace("d", "D")

        txt = txt.Replace("e", "ę")

        txt = txt.Replace("f", "բ")

        txt = txt.Replace("g", "g")

        txt = txt.Replace("h", "৸")

        txt = txt.Replace("i", "i")

        txt = txt.Replace("J", "j")

        txt = txt.Replace("K", "κ")

        txt = txt.Replace("l", "ł")

        txt = txt.Replace("m", "ɱ")

        txt = txt.Replace("N", "П")

        txt = txt.Replace("o", "Φ")

        txt = txt.Replace("p", "ῥ")

        txt = txt.Replace("q", "գ")

        txt = txt.Replace("r", "Я")

        txt = txt.Replace("s", "ʂ")

        txt = txt.Replace("t", "Ʈ")

        txt = txt.Replace("u", "Ц")

        txt = txt.Replace("v", "Ɣ")

        txt = txt.Replace("w", "Щ")

        txt = txt.Replace("x", "ж")

        txt = txt.Replace("y", "Ƴ")

        txt = txt.Replace("z", "ẕżŻ")
        TextBox1.Text = txt
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim txt As String = TextBox2.Text
        TextBox3.Visible = False

        TextBox1.Clear()

        txt = txt.Replace("ا", "أ")

        txt = txt.Replace("ي", "يّ")

        txt = txt.Replace("ك", "ﮏ")

        txt = txt.Replace("ب", "بِ")

        txt = txt.Replace("ا", "أ")

        txt = txt.Replace("ت", "ِِتً")

        txt = txt.Replace("ث", "ثِ")

        txt = txt.Replace("ج", "جٌ")

        txt = txt.Replace("ح", "ـحّ")

        txt = txt.Replace("خ", "خِہ")

        txt = txt.Replace("س", "سُ")

        txt = txt.Replace("ش", "ڜ")

        txt = txt.Replace("ص", "صَ")

        txt = txt.Replace("ض", "ضً")

        txt = txt.Replace("ظ", "ظَ")

        txt = txt.Replace("ع", "عً")

        txt = txt.Replace("غ", "غً")

        txt = txt.Replace("ض", "ضً")

        txt = txt.Replace("ل", "لـ")

        txt = txt.Replace("م", "مہ")

        txt = txt.Replace("ن", "نہ")

        txt = txt.Replace("ه", "هہـ")

        txt = txt.Replace("و", "وُ")

        txt = txt.Replace("ي", "يّــ")
        txt = txt.Replace("a", "ᾄ")

        txt = txt.Replace("b", "в")

        txt = txt.Replace("c", "ƈƈƈ")

        txt = txt.Replace("d", "ḋ")

        txt = txt.Replace("e", "ἔ")

        txt = txt.Replace("f", "ғ")

        txt = txt.Replace("g", "ʛ")

        txt = txt.Replace("h", "ђ")

        txt = txt.Replace("i", "ἷ")

        txt = txt.Replace("J", "ʝ")

        txt = txt.Replace("K", "ќ")

        txt = txt.Replace("l", "ł")

        txt = txt.Replace("m", "м")

        txt = txt.Replace("N", "ᾗ")

        txt = txt.Replace("o", "ὄ")

        txt = txt.Replace("p", "ῥ")

        txt = txt.Replace("q", "գ")

        txt = txt.Replace("r", "ʀ")

        txt = txt.Replace("s", "ʂ")

        txt = txt.Replace("t", "t")

        txt = txt.Replace("u", "մ")

        txt = txt.Replace("v", "v")

        txt = txt.Replace("w", "w")

        txt = txt.Replace("x", "ჯ")

        txt = txt.Replace("y", "Ƴ")

        txt = txt.Replace("z", "~z")
        TextBox1.Text = txt
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim txt As String = TextBox2.Text
        TextBox3.Visible = False

        TextBox1.Clear()
        txt = txt.Replace("ا", "ﭑإ́")

        txt = txt.Replace("ي", "ﮯ")

        txt = txt.Replace("ك", "ﮓ")

        txt = txt.Replace("ب", "پـ")

        txt = txt.Replace("ا", "ﭑإ́")

        txt = txt.Replace("ت", "ﺗـ")

        txt = txt.Replace("ث", "ﺛـ")

        txt = txt.Replace("ج", "ﺠــ")

        txt = txt.Replace("ح", "‏حـ")

        txt = txt.Replace("خ", "ﺥ")

        txt = txt.Replace("س", "ﮨﮨﮨـ")

        txt = txt.Replace("ش", "ـﮨ́́ﮨ́ﮨ")

        txt = txt.Replace("ص", "ﺻـ")

        txt = txt.Replace("ض", "ﻀـ")

        txt = txt.Replace("ظ", "ظ")

        txt = txt.Replace("ع", "ξ")

        txt = txt.Replace("غ", "ﻋ̉̉̀")

        txt = txt.Replace("ض", "ﻀـ")

        txt = txt.Replace("ل", "لـ")

        txt = txt.Replace("م", "ﻤ̉̉ـ")

        txt = txt.Replace("ن", "نـ")

        txt = txt.Replace("ه", "ـﮧ̉ـ")

        txt = txt.Replace("و", "وُ")

        txt = txt.Replace("ي", "ﮯ")
        txt = txt.Replace("a", "მ")

        txt = txt.Replace("b", "Ɓჩ")

        txt = txt.Replace("c", "ƈƈc")

        txt = txt.Replace("d", "ძ")

        txt = txt.Replace("e", "ε")

        txt = txt.Replace("f", "բ")

        txt = txt.Replace("g", "ց")

        txt = txt.Replace("h", "հ")

        txt = txt.Replace("i", "ἶ")

        txt = txt.Replace("J", "ʝ")

        txt = txt.Replace("K", "ƙ")

        txt = txt.Replace("l", "l")

        txt = txt.Replace("m", "ო")

        txt = txt.Replace("N", "ղ")

        txt = txt.Replace("o", "ὄ")

        txt = txt.Replace("p", "ր")

        txt = txt.Replace("q", "գ")

        txt = txt.Replace("r", "գ")

        txt = txt.Replace("s", "ɾ")

        txt = txt.Replace("t", "ʂ")

        txt = txt.Replace("u", "մ")

        txt = txt.Replace("v", "Ɣ")

        txt = txt.Replace("w", "ա")

        txt = txt.Replace("x", "ჯ")

        txt = txt.Replace("y", "Ƴ")
        txt = txt.Replace("z", "ʐ")
        TextBox1.Text = txt
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim txt As String = TextBox2.Text
        TextBox3.Visible = False

        txt = txt.Replace("ا", "ﺂ")

        txt = txt.Replace("ي", "ي")

        txt = txt.Replace("ك", "ﮓ")

        txt = txt.Replace("ب", "ب'ــ́")

        txt = txt.Replace("ا", "ﺂ")

        txt = txt.Replace("ت", "ﺗ'ــ́")

        txt = txt.Replace("ث", "ﺚ")

        txt = txt.Replace("ج", "ﺟ'ـــ")

        txt = txt.Replace("ح", "‏ﺣ'ـــ")

        txt = txt.Replace("خ", "خ'ــ")

        txt = txt.Replace("س", "ﺳ'ــ́")

        txt = txt.Replace("ش", "ﺷ'ــ́ﮨ")

        txt = txt.Replace("ص", "ﺻ'ــ́ـ")

        txt = txt.Replace("ض", "ﺿ'ــ́")

        txt = txt.Replace("ظ", "ظ")

        txt = txt.Replace("ع", "ξ")

        txt = txt.Replace("غ", "ﻍ")

        txt = txt.Replace("ض", "ﺿ'ــ́")

        txt = txt.Replace("ل", "لـ")

        txt = txt.Replace("م", "ﻤ̉̉ـ")

        txt = txt.Replace("ن", "ن'ـ")

        txt = txt.Replace("ه", "ﮪـ")

        txt = txt.Replace("و", "ؤ")

        txt = txt.Replace("ي", "ي")
        txt = txt.Replace("a", "Ǻ")

        txt = txt.Replace("b", "β")

        txt = txt.Replace("c", "Ĉ")

        txt = txt.Replace("d", "Đ")

        txt = txt.Replace("e", "ξَ")

        txt = txt.Replace("f", "ƒ")

        txt = txt.Replace("g", "ģ")

        txt = txt.Replace("h", "ђ")

        txt = txt.Replace("i", "į")

        txt = txt.Replace("J", "Ĵ")

        txt = txt.Replace("K", "Ҝ")

        txt = txt.Replace("l", "ℓ")

        txt = txt.Replace("m", "Ṃ")

        txt = txt.Replace("N", "п")

        txt = txt.Replace("o", "ὄ")

        txt = txt.Replace("p", "ק")

        txt = txt.Replace("q", "Ƣ")

        txt = txt.Replace("r", "")

        txt = txt.Replace("s", "Ṧ")

        txt = txt.Replace("t", "Ṱ")
        txt = txt.Replace("u", "µ")
        txt = txt.Replace("v", "ν")
        txt = txt.Replace("w", "ฟ")
        txt = txt.Replace("x", "א")
        txt = txt.Replace("y", "Ύ")
        txt = txt.Replace("z", "ẕżŻ")
        TextBox1.Text = txt
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim txt As String = TextBox2.Text
        TextBox3.Visible = False

        TextBox1.Clear()

        txt = txt.Replace("ح", "7")
        txt = txt.Replace("ع", "3")
        txt = txt.Replace("أ", "2")
        txt = txt.Replace("ط", "6")
        txt = txt.Replace("ش", "4")
        txt = txt.Replace("خ", "kh")
        txt = txt.Replace("ق", "8")
        txt = txt.Replace("ص", "9")
        txt = txt.Replace("ا", "a")
        txt = txt.Replace("ب", "b")
        txt = txt.Replace("ت", "t")
        txt = txt.Replace("ث", "th")
        txt = txt.Replace("ج", "j")
        txt = txt.Replace("د", "d")
        txt = txt.Replace("ذ", "d'")
        txt = txt.Replace("ر", "r")
        txt = txt.Replace("ز", "z")
        txt = txt.Replace("س", "s")
        txt = txt.Replace("ض", "D")
        txt = txt.Replace("ش", "ch")
        txt = txt.Replace("ظ", "Z")
        txt = txt.Replace("غ", "gh")
        txt = txt.Replace("ق", "8")
        txt = txt.Replace("ف", "f")
        txt = txt.Replace("ك", "k")
        txt = txt.Replace("ل", "l")
        txt = txt.Replace("م", "m")
        txt = txt.Replace("ن", "n")
        txt = txt.Replace("ه", "h")
        txt = txt.Replace("ة", "h")
        txt = txt.Replace("و", "o")
        txt = txt.Replace("ى", "y")
        txt = txt.Replace("ي", "y")
        TextBox1.Text = txt

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim txt As String = TextBox2.Text
        TextBox3.Visible = True
        TextBox3.Clear()

        txt = txt.Replace("ح", "𓎛")
        txt = txt.Replace("ع", "𓂢")
        txt = txt.Replace("أ", "𓄿")
        txt = txt.Replace("ط", "𓎡")
        txt = txt.Replace("ب", "𓃀")
        txt = txt.Replace("خ", "𓐍")
        txt = txt.Replace("ص", "𓋴")
        txt = txt.Replace("ا", "𓏏")
        txt = txt.Replace("ت", "𓍘")
        txt = txt.Replace("ث", "𓍙")
        txt = txt.Replace("ج", "𓇌")
        txt = txt.Replace("د", "𓎡")
        txt = txt.Replace("ذ", "𓎢")
        txt = txt.Replace("ر", "𓇾")
        txt = txt.Replace("ز", "𓍹")
        txt = txt.Replace("س", "𓋴")
        txt = txt.Replace("ض", "𓆑")
        txt = txt.Replace("ش", "𓋴")
        txt = txt.Replace("ظ", "𓆓")
        txt = txt.Replace("غ", "𓉻")
        txt = txt.Replace("ق", "𓋴")
        txt = txt.Replace("ف", "𓍿")
        txt = txt.Replace("ك", "𓂋")
        txt = txt.Replace("ل", "𓆑")
        txt = txt.Replace("م", "𓅓")
        txt = txt.Replace("ن", "𓂧")
        txt = txt.Replace("ه", "𓈖")
        txt = txt.Replace("ة", "𓈖")
        txt = txt.Replace("و", "𓇋")
        txt = txt.Replace("ى", "𓋴")
        txt = txt.Replace("ي", "𓋴")
        txt = txt.Replace("a", "𓏏")
        txt = txt.Replace("b", "𓃀")
        txt = txt.Replace("c", "𓍘")
        txt = txt.Replace("d", "𓎡")
        txt = txt.Replace("e", "𓍙")
        txt = txt.Replace("f", "𓇌")
        txt = txt.Replace("g", "𓐍")
        txt = txt.Replace("h", "𓈖")
        txt = txt.Replace("i", "𓇋")
        txt = txt.Replace("j", "𓋴")
        txt = txt.Replace("k", "𓂋")
        txt = txt.Replace("l", "𓆑")
        txt = txt.Replace("m", "𓅓")
        txt = txt.Replace("n", "𓂧")
        txt = txt.Replace("o", "𓇾")
        txt = txt.Replace("p", "𓂢")
        txt = txt.Replace("q", "𓂊")
        txt = txt.Replace("r", "𓎢")
        txt = txt.Replace("s", "𓋴")
        txt = txt.Replace("t", "𓍿")
        txt = txt.Replace("u", "𓉻")
        txt = txt.Replace("v", "𓅱")
        txt = txt.Replace("w", "𓅱")
        txt = txt.Replace("x", "𓋴")
        txt = txt.Replace("y", "𓋴")
        txt = txt.Replace("z", "𓍹")
        TextBox3.Text = txt

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim txt As String = TextBox2.Text
        TextBox3.Visible = False

        TextBox1.Clear()
        txt = txt.Replace("ي", "ـے")
        txt = txt.Replace("ك", "گ")
        txt = txt.Replace("ب", "بـ?ـ")
        txt = txt.Replace("ا", "أآ")
        txt = txt.Replace("ت", "تـ?ـ")
        txt = txt.Replace("ث", "ثـ")
        txt = txt.Replace("ج", ",ـجـ,")
        txt = txt.Replace("ح", ",حـ,")
        txt = txt.Replace("خ", "خـ")
        txt = txt.Replace("س", "سـ?ـ")
        txt = txt.Replace("ش", "شـ")
        txt = txt.Replace("ص", "صـ?ـ")
        txt = txt.Replace("ض", ",ضـ,")
        txt = txt.Replace("ط", "طــ")
        txt = txt.Replace("ظ", "ظــ")
        txt = txt.Replace("ع", "عـ?ـ")
        txt = txt.Replace("غ", "غـ")
        txt = txt.Replace("ف", "فـ")
        txt = txt.Replace("ق", ",قـ,")
        txt = txt.Replace("ل", "لـ")
        txt = txt.Replace("م", "مـ?ـ")
        txt = txt.Replace("ن", "نـ")
        txt = txt.Replace("ه", "ـہ")
        txt = txt.Replace("و", "ؤؤؤ")
        txt = txt.Replace(" ", " ")
        TextBox1.Text = txt
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Clipboard.SetText(TextBox1.Text)
        Clipboard.SetText(TextBox2.Text)

        Halimm.Show()
        Halimm.Label2.Text = "تم نسخ النص بنجاح إلى الحافظة."
    End Sub
End Class