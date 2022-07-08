Imports System.IO
Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw

Public Class Form1
    Private Sub PDFcreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Pathnijson As String = "D:\Program Files (x86)\Microsoft Visual Studio\source\repos-1\PDFresumeCreatorvb\PDFresumeCreatorvb\PDFResumeCreator.json"
        Dim Openjson As String = File.ReadAllText(Pathnijson)
        Dim Outputnijson As JsonReader = JsonConvert.DeserializeObject(Of JsonReader)(Openjson)
        Dim [Resume] As Document = New Document()
        PdfWriter.GetInstance([Resume], New FileStream("D:\Program Files (x86)\Microsoft Visual Studio\source\repos-1\PDFresumeCreatorvb\PDFresumeCreatorvb\GALICIA_CARLJEREMY.pdf", FileMode.Create))
        Dim font1 As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 16, iTextSharp.text.Font.BOLD)
        Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(Outputnijson.Image)
        image.ScalePercent(13.0F)
        image.Alignment = 6
        Dim FName As Paragraph = New Paragraph(Outputnijson.Full_Name, font1)
        Dim CurrentAddress1 As Paragraph = New Paragraph(Outputnijson.Address1)
        Dim CurrentAddress2 As Paragraph = New Paragraph(Outputnijson.Address2)
        Dim emailAdd As Paragraph = New Paragraph(Outputnijson.Email)
        Dim ContactNo As Paragraph = New Paragraph(Outputnijson.Contact & vbLf & vbLf)
        Dim separator1 As LineSeparator = New LineSeparator(2.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        Dim subtitle1 As Paragraph = New Paragraph(Outputnijson.Subtitle1 & vbLf & vbLf, font1)
        Dim infoko As Paragraph = New Paragraph(Outputnijson.Details & vbLf & vbLf)
        Dim subtitle2 As Paragraph = New Paragraph(Outputnijson.Subtitle2 & vbLf & vbLf, font1)
        Dim birthday As Paragraph = New Paragraph(Outputnijson.Birthdate)
        Dim religion As Paragraph = New Paragraph(Outputnijson.Religion)
        Dim nationality As Paragraph = New Paragraph(Outputnijson.Nationality)
        Dim age As Paragraph = New Paragraph(Outputnijson.Age)
        Dim civilstatus As Paragraph = New Paragraph(Outputnijson.Civil_Status & vbLf & vbLf)
        Dim subtitle3 As Paragraph = New Paragraph(Outputnijson.Subtitle3 & vbLf & vbLf, font1)
        Dim educlevel1 As Paragraph = New Paragraph(Outputnijson.Educlevel1)
        Dim educschool1 As Paragraph = New Paragraph(Outputnijson.EducSchool1)
        Dim educcourse As Paragraph = New Paragraph(Outputnijson.EducCourse)
        Dim educaddresss1 As Paragraph = New Paragraph(Outputnijson.EducAddress1)
        Dim educyear1 As Paragraph = New Paragraph(Outputnijson.EducYear1 & vbLf & vbLf)
        Dim educlevel2 As Paragraph = New Paragraph(Outputnijson.Educlevel2)
        Dim educschool2 As Paragraph = New Paragraph(Outputnijson.EducSchool2)
        Dim educaddresss2 As Paragraph = New Paragraph(Outputnijson.EducAddress2)
        Dim educyear2 As Paragraph = New Paragraph(Outputnijson.EducYear2 & vbLf & vbLf)
        Dim educlevel3 As Paragraph = New Paragraph(Outputnijson.Educlevel3)
        Dim educschool3 As Paragraph = New Paragraph(Outputnijson.EducSchool3)
        Dim educaddresss3 As Paragraph = New Paragraph(Outputnijson.EducAddress3)
        Dim educyear3 As Paragraph = New Paragraph(Outputnijson.EducYear3 & vbLf & vbLf)
        Dim subtitle4 As Paragraph = New Paragraph(Outputnijson.Subtitle4 & vbLf & vbLf, font1)
        Dim skills1 As Paragraph = New Paragraph(Outputnijson.Skills1)
        Dim skills2 As Paragraph = New Paragraph(Outputnijson.Skills2)
        Dim skills3 As Paragraph = New Paragraph(Outputnijson.Skills3)
        Dim skills4 As Paragraph = New Paragraph(Outputnijson.Skills4 & vbLf & vbLf & vbLf)
        Dim certify As Paragraph = New Paragraph(Outputnijson.Certify)
        certify.Alignment = Element.ALIGN_CENTER
        [Resume].Open()
        [Resume].Add(image)
        [Resume].Add(FName)
        [Resume].Add(CurrentAddress1)
        [Resume].Add(CurrentAddress2)
        [Resume].Add(emailAdd)
        [Resume].Add(ContactNo)
        [Resume].Add(separator1)
        [Resume].Add(subtitle1)
        [Resume].Add(separator1)
        [Resume].Add(infoko)
        [Resume].Add(subtitle2)
        [Resume].Add(separator1)
        [Resume].Add(birthday)
        [Resume].Add(religion)
        [Resume].Add(nationality)
        [Resume].Add(age)
        [Resume].Add(civilstatus)
        [Resume].Add(subtitle3)
        [Resume].Add(separator1)
        [Resume].Add(educlevel1)
        [Resume].Add(educschool1)
        [Resume].Add(educcourse)
        [Resume].Add(educaddresss1)
        [Resume].Add(educyear1)
        [Resume].Add(educlevel2)
        [Resume].Add(educschool2)
        [Resume].Add(educaddresss2)
        [Resume].Add(educyear2)
        [Resume].Add(educlevel3)
        [Resume].Add(educschool3)
        [Resume].Add(educaddresss3)
        [Resume].Add(educyear3)
        [Resume].Add(subtitle4)
        [Resume].Add(separator1)
        [Resume].Add(skills1)
        [Resume].Add(skills2)
        [Resume].Add(skills3)
        [Resume].Add(skills4)
        [Resume].Add(certify)
        [Resume].Close()
    End Sub

    Public Class JsonReader
        Public Property Full_Name As String
        Public Property Address1 As String
        Public Property Address2 As String
        Public Property Image As String
        Public Property Email As String
        Public Property Contact As String
        Public Property Subtitle1 As String
        Public Property Details As String
        Public Property Subtitle2 As String
        Public Property Birthdate As String
        Public Property Religion As String
        Public Property Nationality As String
        Public Property Age As String
        Public Property Civil_Status As String
        Public Property Subtitle3 As String
        Public Property Educlevel1 As String
        Public Property EducSchool1 As String
        Public Property EducCourse As String
        Public Property EducAddress1 As String
        Public Property EducYear1 As String
        Public Property Educlevel2 As String
        Public Property EducSchool2 As String
        Public Property EducAddress2 As String
        Public Property EducYear2 As String
        Public Property Educlevel3 As String
        Public Property EducSchool3 As String
        Public Property EducAddress3 As String
        Public Property EducYear3 As String
        Public Property Subtitle4 As String
        Public Property Skills1 As String
        Public Property Skills2 As String
        Public Property Skills3 As String
        Public Property Skills4 As String
        Public Property Certify As String
    End Class
End Class
