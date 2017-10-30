Public Class Revision_Menu
    Private Sub Previous()
        Lbl_Content.Text = "The Processor is responcible for instruction in order to produce an output.
      Typical data processing activities include:
      Sorting and Sorting data
      Perfroming Calculations
      Logical Decision-Making
      Control of input, Output and Storage Devices
"
    End Sub
    Private Sub Next1()

    End Sub
    Private Sub Revision_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmd_Previous.Enabled = False
        Previous()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Cmd_Previous.Click
        Previous()
    End Sub

    Private Sub Cmd_Next_Click(sender As Object, e As EventArgs) Handles Cmd_Next.Click
        Content()
    End Sub
    Private Sub Content()
        Lbl_Content.Text = "
Arithmetic logic unit carries out arithmetic operations such as addition, multiplication, subtraction and division.
It can also make logical comparisons between items of data;
For example, it can determine whether one value is greater than another. 
Such logical operations can also be performed on non-numeric data. 
The Pentium was the first Intel processor to have two ALUs so it could manipulate two sets of numbers at the same time.
The result of the ALU is held in a register called the accumulator."
        System.Threading.Thread.Sleep(10000)
        Me.Refresh()
        System.Threading.Thread.Sleep(10000)
        Lbl_Content.Text = "
Control unit (CU)
The control unit (CU) governs the operation of all hardware, including input and output devices and the CPU.
It does this by fetching, interpreting and executing each instruction in turn, in an automatically controlled cycle;
this fetch–execute cycle is described in detail below.

Clock
The Clock is the part of the processor that regulates all of the actions that take place. 
The clock provides a regular pulse of high voltage followed by low voltage (voltage is the electrical ‘pressure’ placed on the wire).
Each high-to-low transition is known as a cycle, and each cycle implements an instruction.

Program counter (PC)
The program counter (PC) holds the address of the next instruction to be executed. 
When a sequence of instructions is to be executed the PC is automatically incremented to point to the next instruction. 
Depending on the length of the current instruction, 1, 2 or 3 has to be added to its contents unless the current instruction is a jump,
in which case the destination address is used if the test is successful. 

Memory buffer register (MBR)
Values about to be added or subtracted can be copied, via the memory buffer register (MBR), sometimes called the memory data register (MDR), into the accumulators. 
The arithmetic result can be placed in one accumulator and copied from there into a main memory location. 
All communications between the CPU and the memory take place through the MBR. 

"
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.teach-ict.com/2016/AS_Computing/OCR_H046/OCR_H046_home.html")

    End Sub
End Class