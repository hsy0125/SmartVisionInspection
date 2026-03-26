# SmartVisionInspection 구조/기능 명세서

## 1. 문서 목적

- 본 문서는 `SmartVisionInspection` 프로젝트의 전체 구조와 핵심 기능을 운영/개발 관점에서 빠르게 이해할 수 있도록 정리한 기술 명세다.
- 대상 독자는 신규 개발자, 유지보수 담당자, 현장 엔지니어다.

## 2. 시스템 개요

- 유형: Windows 데스크톱 비전 검사 애플리케이션
- UI 프레임워크: WinForms + Docking UI
- 런타임: .NET Framework 4.8
- 핵심 역할:
  - 카메라 또는 파일 이미지 입력
  - ROI(검사 윈도우) 기반 검사 실행
  - 검사 결과 시각화/판정
  - 모델(티칭 데이터) 저장/복원
  - 로그 및 환경설정 관리

## 3. 기술 스택 및 외부 의존성

- 언어/플랫폼: C#, .NET Framework 4.8
- 영상 처리: OpenCvSharp
- 카메라 SDK: HikRobot (`MvCameraControl.Net`)
- 로깅: log4net
- UI 컴포넌트:
  - `WeifenLuo.WinFormsUI.Docking`
  - `ObjectListView`
- AI SDK(선택 기능): `SaigeVision.Net.*`
- 의존성 방식: NuGet 중심이 아닌 `ExternalLib` DLL 참조(`HintPath`) 기반

## 4. 프로젝트 구조

- 솔루션/프로젝트
  - `SmartVisionInspection.slnx`
  - `SmartVisionInspection/SmartVisionInspection.csproj`
- 주요 디렉터리(프로젝트 내부)
  - `Algorithm/`: 매칭/Blob 등 검사 알고리즘
  - `Core/`: 검사 스테이지, 이미지 버퍼, 전역 제어
  - `Grab/`: 카메라 추상화 및 장치별 구현(WebCam/HikRobot)
  - `Inspect/`: 검사 실행 로직, 결과 객체, AI 래퍼
  - `Teach/`: 모델/ROI 정의 및 직렬화(저장/복원)
  - `Setting/`: 환경설정 화면 및 XML 저장 로직
  - `UIControl/`, `Property/`: 사용자 컨트롤 및 속성 UI
  - 루트 폼: `MainForm`, `CameraForm`, `ResultForm`, `RunForm`, `LogForm`, `ModelTreeForm`, `PropertiesForm`

## 5. 실행 구조

### 5.1 엔트리포인트

- `Program.cs`
  - `Main()`에서 log4net 설정 로드
  - `MainForm` 실행

### 5.2 메인 화면 구성

- `MainForm.cs`에서 도킹 기반 다중 화면 구성
  - 카메라 뷰(`CameraForm`)
  - 결과 뷰(`ResultForm`)
  - 모델 트리(`ModelTreeForm`)
  - 실행 패널(`RunForm`)
  - 속성 패널(`PropertiesForm`)
  - 로그 뷰(`LogForm`)

### 5.3 런타임 코어

- `Core/InspStage.cs`
  - 카메라 초기화/전환
  - 이미지 버퍼 설정
  - 모델 로드/저장
  - 단건 검사/연속 검사 실행

## 6. 기능 명세

### 6.1 영상 입력 기능

- 카메라 입력
  - 공통 인터페이스: `Grab/GrabModel.cs`
  - 구현체: `Grab/WebCam.cs`, `Grab/HikRobotCam.cs`
- 파일 입력
  - 파일 이미지 로드 후 검사 버퍼 설정
- 가상 연속 입력
  - 폴더 내 이미지 순회 로딩 기반 반복 검사(`VirtualGrab` 경로)

### 6.2 모델/티칭 기능

- 모델 구조
  - `Teach/Model.cs`: 모델 메타 + ROI 목록(`InspWindowList`) 관리
- ROI(검사 윈도우)
  - `Teach/InspWindow.cs`: ROI 영역/알고리즘/템플릿 연동
  - `Teach/InspWindowFactory.cs`: 타입 기반 ROI 객체 생성
- 저장/복원
  - 모델 XML 저장/로드
  - ROI 템플릿 이미지는 모델 하위 `Images/*.png`로 저장

### 6.3 검사 기능

- 알고리즘 모듈
  - `Algorithm/MatchAlgorithm.cs`
    - 템플릿 매칭(단일/복수 매칭)
  - `Algorithm/BlobAlgorithm.cs`
    - 이진화 + Blob 기반 픽셀/영역 판정
- 검사 실행
  - `Inspect/InspectBoard.cs`
    - ROI별 입력 업데이트
    - 알고리즘 실행 및 결과 집계
- 결과 처리
  - 합격/불합격(OK/NG) 판정
  - ROI별 상세 결과 보존

### 6.4 결과 시각화 기능

- `ResultForm.cs`
  - 트리/리스트 형태 결과 표시
  - 검사 항목별 상세 확인
- `CameraForm.cs`
  - 원본/처리 이미지 표시
  - ROI, 검사 오버레이, 선택 영역 시각화

### 6.5 설정/로그 기능

- 설정
  - `Setting/SettingXml.cs`
  - 저장 위치: `Setup/Setting.xml`
- 로깅
  - 설정 파일: `log4net.config`
  - 출력 파일: `Logs/log.log`
  - 로거 유틸: `Util/SLogger.cs`

### 6.6 AI 확장 기능(선택)

- `Inspect/SaigeAI.cs`
  - Anomaly / Segmentation / Detection 래핑
  - 모델 로드 및 추론 호출 처리
- 현장 구성 및 라이선스/모델 파일 준비 상태에 따라 활성/비활성 가능

## 7. 데이터 흐름 명세

1. 앱 시작 (`Program` -> `MainForm`)
2. 전역/스테이지 초기화 (`Global.Initialize` -> `InspStage.Initialize`)
3. 입력 취득 (카메라 Grab 또는 파일 로드)
4. 이미지 버퍼 반영 (`ImageSpace`/버퍼 갱신)
5. 모델의 ROI 목록 순회
6. ROI별 검사 입력 업데이트
7. 알고리즘 실행 (`InspectBoard.DoInspect`)
8. 결과 판정/집계
9. UI 반영 (`ResultForm`, `CameraForm`)
10. 필요 시 모델/설정/로그 파일 저장

## 8. 저장소/영속 데이터

- 모델 데이터: 모델 XML 파일
- ROI 템플릿: 모델 폴더 `Images/*.png`
- 환경설정: `Setup/Setting.xml`
- 로그: `Logs/log.log`
- 최근 모델 경로: Windows Registry `HKCU\Software\SmartVisionInspection`

## 9. 운영 관점 명세

- 예상 운영 환경
  - Windows 현장 PC + 카메라 장치(HikRobot/WebCam)
- 장애/점검 포인트
  - 카메라 SDK 인식/권한
  - 외부 DLL 누락(`ExternalLib`)
  - 모델 파일/템플릿 파일 경로 유효성
  - 로그 파일 생성 권한
- 오프라인 운용
  - 카메라 없이 파일 기반 검사 가능(`CameraType.None`/가상 입력 경로)

## 10. 빌드/배포/품질 현황

- 빌드 방식: Visual Studio/MSBuild 기반 데스크톱 빌드
- CI/CD: 저장소 내 파이프라인 정의 파일 확인되지 않음
- 테스트: 별도 테스트 프로젝트/자동 테스트 코드 확인되지 않음
- 문서: 공식 README/운영 가이드 문서 부재

## 11. 리스크 및 개선 권장사항

- 자동 테스트 부재
  - ROI/알고리즘 회귀 테스트 추가 권장
- 의존성 관리 개선
  - `ExternalLib` 직접 참조를 NuGet/버전 관리 가능한 형태로 전환 권장
- 배포 표준화 필요
  - 설치 패키지(Installer) 또는 릴리스 절차 문서화 권장
- 문서화 확대
  - 모델 포맷, 카메라 설정, 트리거 설정, 장애 대응 가이드 추가 권장

## 12. 확인 필요 항목

- 실제 현장 배포 방식(설치형/단일 실행 파일)
- AI 모듈의 운영 필수 여부 및 라이선스 체계
- 추가 알고리즘 타입 확장 시 `InspWindowFactory` 매핑 일관성

